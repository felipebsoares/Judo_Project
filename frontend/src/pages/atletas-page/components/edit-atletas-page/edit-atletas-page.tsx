import { Edit } from '@mui/icons-material';
import { Box, Button } from '@mui/material';
import { useNavigate } from 'react-router-dom';
import { PageHeader } from '../../../../shared/components';
import { LayoutBase } from '../../../../shared/layout';

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
    </LayoutBase>
  );
};
