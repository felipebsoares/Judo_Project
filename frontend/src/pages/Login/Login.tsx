import { useState } from 'react';
import { Box, Typography, Link, Card, CardContent } from '@mui/material';
import { yupResolver } from '@hookform/resolvers/yup';
import { FormProvider, SubmitHandler, useForm } from 'react-hook-form';

import { FormLogin } from './components';
import { LoginForm, loginValidator } from '../../shared/domain-types';
import { useAuth } from '../../shared/hooks';

export const Login: React.FC = () => {
  const [isLoading, setIsLoading] = useState(false);
  const { login } = useAuth();

  const form = useForm<LoginForm>({
    mode: 'onChange',
    resolver: yupResolver(loginValidator),
  });

  const onSubmit: SubmitHandler<LoginForm> = (data) => {
    setIsLoading(true);
    login(data.email, data.password).then(() => {
      setIsLoading(false);
    });
  };

  return (
    <>
      <Box
        display="flex"
        alignItems="center"
        flexDirection="column"
        justifyContent="center"
        height="100vh"
        sx={{ backgroundColor: '#e9ecef' }}
      >
        <Card>
          <CardContent
            sx={{
              display: 'flex',
              flexDirection: 'column',
              py: '2rem',
              px: '2rem',
              gap: '1rem',
            }}
          >
            <Typography
              sx={{ marginBottom: '1rem' }}
              variant="h4"
              align="center"
            >
              Entrar
            </Typography>

            <FormProvider {...form}>
              <FormLogin isLoading={isLoading} onSubmit={onSubmit} />
            </FormProvider>

            <Link
              href="#"
              variant="body1"
              underline="always"
              sx={{ textAlign: 'center' }}
            >
              Recuperar a Senha
            </Link>
          </CardContent>
        </Card>
      </Box>
    </>
  );
};
