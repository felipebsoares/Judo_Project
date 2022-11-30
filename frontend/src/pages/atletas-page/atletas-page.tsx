import { Button } from '@mui/material';
import { useNavigate } from 'react-router-dom';
import { SportsKabaddi } from '@mui/icons-material';
import { useModal } from '../../shared/hooks';
import { LayoutBase } from '../../shared/layout';
import { PageHeader } from '../../shared/components';
import { RemoveAtletasModal, TableAtletas } from './components';
import { useEffect, useState } from 'react';
import { ListGetAll } from '../../shared/services/atletas';
import { Alert } from '../../shared/adapters';
import { Atletas } from '../../shared/services';

export const AtletasPage: React.FC = () => {
  const navigate = useNavigate();
  const [data, setData] = useState<Atletas[]>([]);

  const [isRemoveModalOpen, openRemoveModal, closeRemoveModal] = useModal();

  useEffect(() => {
    ListGetAll().then((result) => {
      if (result instanceof Error) {
        Alert.callError({
          title: (result as Error).name,
          description: (result as Error).message,
        });
        return;
      } else {
        setData(result);
      }
    });
  }, []);

  return (
    <>
      <LayoutBase>
        <PageHeader
          title="Atletas"
          description="Página de gerenciamento dos Atletas"
          icon={SportsKabaddi}
          action={
            <Button
              variant="contained"
              onClick={() => navigate('/atletas/cadastro')}
            >
              Novo
            </Button>
          }
        />

        <TableAtletas rows={data} removeModal={openRemoveModal} />
      </LayoutBase>

      <RemoveAtletasModal
        handleClose={closeRemoveModal}
        open={isRemoveModalOpen}
      />
    </>
  );
};
