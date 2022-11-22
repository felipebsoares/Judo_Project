import { useState } from 'react';
import { Box, Typography, Link } from '@mui/material';
import { yupResolver } from '@hookform/resolvers/yup';
import { FormProvider, SubmitHandler, useForm } from 'react-hook-form';

import { FormLogin } from './components';
import { LoginForm, loginValidator } from '../../shared/domain-types';

export const Login: React.FC = () => {
  const [isLoading, setIsLoading] = useState(false);

  const form = useForm<LoginForm>({
    mode: 'onChange',
    resolver: yupResolver(loginValidator),
  });

  const onSubmit: SubmitHandler<LoginForm> = (data) => {
    console.log(data);
  };

  return (
    <Box
      display="flex"
      alignItems="center"
      flexDirection="column"
      justifyContent="center"
      height="100vh"
    >
      <Typography sx={{ marginBottom: '1rem' }} variant="h4" align="center">
        Entrar
      </Typography>

      <FormProvider {...form}>
        <FormLogin isLoading={isLoading} onSubmit={onSubmit} />
      </FormProvider>

      <Link
        href="#"
        variant="body2"
        underline="always"
        sx={{ textAlign: 'center' }}
      >
        Recuperar a Senha
      </Link>
    </Box>
  );
};
