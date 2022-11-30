import { Add } from '@mui/icons-material';
import { useNavigate } from 'react-router-dom';
import {
  Box,
  Button,
  Card,
  CardContent,
  CircularProgress,
  Divider,
  Typography,
} from '@mui/material';
import { FormProvider, SubmitHandler, useForm } from 'react-hook-form';

import { AtletasForm } from '../../components';
import { LayoutBase } from '../../../../shared/layout';
import { PageHeader } from '../../../../shared/components';
import { FormAtletas } from '../../../../shared/domain-types';
import { useState } from 'react';
import { ListCreate } from '../../../../shared/services/atletas';
import { Alert } from '../../../../shared/adapters';

export const AddAtletasPage: React.FC = () => {
  const form = useForm<FormAtletas>({
    mode: 'onChange',
  });

  const navigate = useNavigate();
  const [isLoading, setIsLoading] = useState(false);

  const onSubmit: SubmitHandler<FormAtletas> = (data) => {
    setIsLoading(true);
    ListCreate(data).then((result) => {
      if (result instanceof Error) {
        setIsLoading(false);
        console.log(result);
        Alert.callError({
          title: (result as Error).name,
          description: (result as Error).message,
        });

        form.reset();
        return;
      }

      setIsLoading(false);

      Alert.callSuccess({
        title: 'Atleta cadastrado',
        onConfirm: () => navigate('/atletas'),
      });
    });
  };

  return (
    <LayoutBase>
      <PageHeader
        title="Cadastrar Atletas"
        description="Use o formulário abaixo para cadastrar um novo atleta"
        icon={Add}
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
        {isLoading ? (
          <Button
            disabled={!form.formState.isValid}
            type="submit"
            form="add-atletas-form"
            variant="contained"
          >
            <CircularProgress
              variant="indeterminate"
              color="inherit"
              size={15}
            />
          </Button>
        ) : (
          <Button
            disabled={!form.formState.isValid}
            form="add-atletas-form"
            type="submit"
            variant="contained"
          >
            Entrar
          </Button>
        )}
      </Box>
    </LayoutBase>
  );
};
