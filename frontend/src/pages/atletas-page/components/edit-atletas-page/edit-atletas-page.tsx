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

export const EditAtletasPage: React.FC = () => {
  const navigate = useNavigate();

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
          <AtletasForm />
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
        <Button variant="contained" color="primary">
          Salvar
        </Button>
      </Box>
    </LayoutBase>
  );
};
