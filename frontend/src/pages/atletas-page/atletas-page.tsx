import { Button } from '@mui/material';
import { useNavigate } from 'react-router-dom';
import { SportsKabaddi } from '@mui/icons-material';
import { useModal } from '../../shared/hooks';
import { LayoutBase } from '../../shared/layout';
import { PageHeader, TableData, Table } from '../../shared/components';
import { RemoveAtletasModal } from './components';

const rows: TableData[] = [
  { name: 'Frozen yoghurt', calories: 159, carbs: 6.0, fat: 24, protein: 4.0 },
  { name: 'Frozen yoghurt', calories: 159, carbs: 6.0, fat: 24, protein: 4.0 },
  { name: 'Frozen yoghurt', calories: 159, carbs: 6.0, fat: 24, protein: 4.0 },
  { name: 'Frozen yoghurt', calories: 159, carbs: 6.0, fat: 24, protein: 4.0 },
  { name: 'Frozen yoghurt', calories: 159, carbs: 6.0, fat: 24, protein: 4.0 },
  { name: 'Frozen yoghurt', calories: 159, carbs: 6.0, fat: 24, protein: 4.0 },
  { name: 'Frozen yoghurt', calories: 159, carbs: 6.0, fat: 24, protein: 4.0 },
  { name: 'Frozen yoghurt', calories: 159, carbs: 6.0, fat: 24, protein: 4.0 },
  { name: 'Frozen yoghurt', calories: 159, carbs: 6.0, fat: 24, protein: 4.0 },
  { name: 'Frozen yoghurt', calories: 159, carbs: 6.0, fat: 24, protein: 4.0 },
];

export const AtletasPage: React.FC = () => {
  const navigate = useNavigate();

  const [isRemoveModalOpen, openRemoveModal, closeRemoveModal] = useModal();

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
        <Table rows={rows} removeModal={openRemoveModal} />
      </LayoutBase>

      <RemoveAtletasModal
        handleClose={closeRemoveModal}
        open={isRemoveModalOpen}
      />
    </>
  );
};
