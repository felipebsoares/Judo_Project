import { ConfirmModal, ConfirmModalProps } from '../../../../shared/components';

type Props = Omit<ConfirmModalProps, 'title' | 'message'>;

export const RemoveAtletasModal: React.FC<Props> = ({ handleClose, open }) => {
  const modalConfigs: ConfirmModalProps = {
    handleClose,
    open,
    title: 'Remoção do Atleta',
    message: `Tem certeza de que deseja excluir (o/a) atleta João Carlos?`,
  };

  return <ConfirmModal {...modalConfigs} />;
};
