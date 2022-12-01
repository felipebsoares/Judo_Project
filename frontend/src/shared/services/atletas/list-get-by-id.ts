import { api } from '../../api';
import { FormAtletas } from '../../domain-types';

export const listGetById = async (id: number): Promise<FormAtletas | Error> => {
  try {
    const { data } = await api.get(`/api/Atleta/obter-atleta-por-${id}`);

    if (data) {
      return data;
    }

    return new Error('Erro ao buscar a tarefa');
  } catch (error) {
    return new Error('Erro ao buscar a tarefa');
  }
};
