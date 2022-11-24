import { Button } from '@mui/material';
import { useNavigate } from 'react-router-dom';
import { SportsKabaddi } from '@mui/icons-material';
import { useModal } from '../../shared/hooks';
import { LayoutBase } from '../../shared/layout';
import {
  PageHeader,
  TableData,
  Table,
  Modal,
  ConfirmModal,
} from '../../shared/components';

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
  const [isAddModalOpen, openAddModal, closeAddModal] = useModal();

  const navigate = useNavigate();

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
        <Table rows={rows} />
      </LayoutBase>

      {/* <Modal
        handleClickOpen={openAddModal}
        handleClose={closeAddModal}
        open={isAddModalOpen}
      /> */}

      {/* <ConfirmModal handleClose={() => console.log('')} open={true} /> */}
    </>
  );
};
