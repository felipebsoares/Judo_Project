import { api } from '../../api';

export const ListDelete = async (
  id: number | undefined,
): Promise<void | Error> => {
  try {
    await api.delete(`/api/Atleta/Remover-Atleta-por-${id}`);
  } catch (error) {
    return new Error('Erro ao remove o item da lista');
  }
};
