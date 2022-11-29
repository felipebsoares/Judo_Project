import { Edit } from '@mui/icons-material';
import {
  Box,
  Button,
  Card,
  CardContent,
  Divider,
  Typography,
} from '@mui/material';
import { useNavigate } from 'react-router-dom';
import { PageHeader } from '../../../../shared/components';
import { LayoutBase } from '../../../../shared/layout';
import { AtletasForm } from '../../components';
import { FormProvider, SubmitHandler, useForm } from 'react-hook-form';
import { FormAtletas } from '../../../../shared/domain-types';
import { useState } from 'react';

export const EditAtletasPage: React.FC = () => {
  const form = useForm<FormAtletas>({
    mode: 'onChange',
  });

  const navigate = useNavigate();
  const [isLoading, setIsLoading] = useState(false);

  const onSubmit: SubmitHandler<FormAtletas> = (data) => {
    console.log(data);
  };

  return (
    <LayoutBase>
      <PageHeader
        title="Edição Atletas"
        description="Use o formulário abaixo para atualizar os dados do atleta em nosso banco de dados"
        icon={Edit}
        action={
          <Button variant="contained" onClick={() => navigate('/atletas')}>
            Voltar
          </Button>
        }
      />

      <Card>
        <CardContent>
          <Box sx={{ mb: 2 }}>
            <Typography gutterBottom variant="h6" component="div">
              Dados do Atleta
            </Typography>

            <Divider />
          </Box>
          <FormProvider {...form}>
            <AtletasForm id="add-atletas-form" onSubmit={onSubmit} />
          </FormProvider>
        </CardContent>
      </Card>

      <Box
        sx={{
          display: 'flex',
          justifyContent: 'end',
          gap: 2,
          py: 2,
        }}
      >
        <Button
          variant="contained"
          color="error"
          onClick={() => navigate('/atletas')}
        >
          Cancelar
        </Button>
        <Button
          form="add-atletas-form"
          type="submit"
          variant="contained"
          color="primary"
          disabled={!form.formState.isValid}
        >
          Salvar
        </Button>
      </Box>
    </LayoutBase>
  );
};
