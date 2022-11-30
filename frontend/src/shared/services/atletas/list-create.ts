import { api } from '../../api';
import { FormAtletas } from '../../domain-types';

export const ListCreate = async (
  dataList: FormAtletas,
): Promise<FormAtletas | Error> => {
  try {
    const { data } = await api.post<FormAtletas>(
      '/api/Atleta/Criar-Atleta',
      dataList,
    );

    if (data) {
      return data;
    }

    return new Error('Erro ao criar a tarefa.');
  } catch (error) {
    return new Error('Erro ao criar a tarefa');
  }
};
