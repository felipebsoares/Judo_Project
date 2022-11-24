import { Add } from '@mui/icons-material';
import { useNavigate } from 'react-router-dom';
import {
  Box,
  Button,
  Card,
  CardContent,
  Divider,
  Typography,
} from '@mui/material';

import { AtletasForm } from '../../components';
import { LayoutBase } from '../../../../shared/layout';
import { PageHeader } from '../../../../shared/components';

export const AddAtletasPage: React.FC = () => {
  const navigate = useNavigate();

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
          <AtletasForm />
        </CardContent>
      </Card>
    </LayoutBase>
  );
};
