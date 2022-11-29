import { Button } from '@mui/material';
import { useNavigate } from 'react-router-dom';
import { SportsKabaddi } from '@mui/icons-material';
import { useModal } from '../../shared/hooks';
import { LayoutBase } from '../../shared/layout';
import { PageHeader } from '../../shared/components';
import { TableDataRows, RemoveAtletasModal, TableAtletas } from './components';

export const AtletasPage: React.FC = () => {
  const navigate = useNavigate();

  const [isRemoveModalOpen, openRemoveModal, closeRemoveModal] = useModal();

  const rows: TableDataRows[] = [
    {
      nameAthlete: 'João Augusto',
      profession: 'Goleiro',
      selection: 'equador',
      federation: 'Brasil',
      confederation: 'Não sei',
    },
  ];

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

        <TableAtletas rows={rows} removeModal={openRemoveModal} />
      </LayoutBase>

      <RemoveAtletasModal
        handleClose={closeRemoveModal}
        open={isRemoveModalOpen}
      />
    </>
  );
};
