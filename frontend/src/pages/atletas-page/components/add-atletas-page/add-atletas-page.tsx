import { Button } from '@mui/material';
import { PageHeader } from '../../../../shared/components';
import { LayoutBase } from '../../../../shared/layout';
import { Add } from '@mui/icons-material';

import { useNavigate } from 'react-router-dom';

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
    </LayoutBase>
  );
};
