import { Dispatch, SetStateAction } from 'react';
import { Alert } from '../../../../shared/adapters';
import { ConfirmModal, ConfirmModalProps } from '../../../../shared/components';
import { Atletas, ListDelete } from '../../../../shared/services';

type Props = Omit<ConfirmModalProps, 'title' | 'message'> & {
  name: string | undefined;
  id: number | undefined;
  setData: Dispatch<SetStateAction<Atletas[]>>;
};

export const RemoveAtletasModal: React.FC<Props> = ({
  handleClose,
  open,
  name,
  id,
  setData,
}) => {
  const onConfirm = async () => {
    ListDelete(id).then((result) => {
      handleClose();
      if (result instanceof Error) {
        Alert.callError({
          title: (result as Error).name,
          description: (result as Error).message,
        });
        return;
      }

      Alert.callSuccess({
        title: 'Item removido com sucesso!',
        onConfirm: handleClose,
      });

      setData((data) => data.filter((list) => list.idAtleta !== id));
    });
  };

  const modalConfigs: ConfirmModalProps = {
    onConfirm,
    handleClose,
    open,
    title: 'Remoção do Atleta',
    message: `Tem certeza de que deseja excluir (o/a) atleta ${name}?`,
  };

  return <ConfirmModal {...modalConfigs} />;
};
