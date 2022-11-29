import * as yup from 'yup';
import { LoginForm } from '../models';

export const loginValidator: yup.SchemaOf<LoginForm> = yup.object({
  email: yup.string().email('E-mail inválido').required('E-mail é obrigatório'),
  password: yup.string().required('Senha é obrigatório'),
});
