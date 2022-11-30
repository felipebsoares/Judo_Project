import { api } from '../../api';
import { Atletas } from '../types';

export const ListGetAll = async (): Promise<Atletas[] | Error> => {
  try {
    const { data } = await api.get('/api/Atleta/Obter-todos-atletas');

    if (data) {
      return data;
    }

    return new Error('Erro ao listar os Atletas');
  } catch (error) {
    return new Error('Erro ao listar os Atletas');
  }
};
