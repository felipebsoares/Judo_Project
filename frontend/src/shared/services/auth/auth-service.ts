import { api } from '../../api';
import { Auth } from '../types';

export const AuthService = async (
  email: string | undefined,
  password: string | undefined,
): Promise<Auth | Error> => {
  try {
    const { data } = await api.post('/Auth/Login', {
      email,
      password,
    });

    if (data) {
      return data;
    }

    return new Error('Erro no Login!');
  } catch (error: any) {
    return new Error(
      error.response?.data.erros ||
        (error as { message: string }).message ||
        'Erro no Login',
    );
  }
};
