import { Visibility } from '@mui/icons-material';
import { Button, Typography } from '@mui/material';
import { PageHeader } from '../../shared/components';
import { LayoutBase } from '../../shared/layout';

export const AtletasPage: React.FC = () => {
  return (
    <LayoutBase>
      <Typography>
        <PageHeader
          title="Listas"
          description="Página de gerenciamento das listas"
          icon={Visibility}
          action={<Button variant="contained">Novo</Button>}
        />
      </Typography>
    </LayoutBase>
  );
};
