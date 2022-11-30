import { api } from '../../api';
import { Auth } from '../types';

export const AuthService = async (
  email: string | undefined,
  senha: string | undefined,
): Promise<Auth | Error> => {
  try {
    const { data } = await api.post('/Auth/Login', {
      email,
      senha,
    });

    if (data) {
      return data;
    }

    return new Error('Erro no Login!');
  } catch (error: any) {
    return new Error('Erro no Login');
  }
};
