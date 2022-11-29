import { useState } from 'react';
import { Visibility, VisibilityOff } from '@mui/icons-material';
import { SubmitHandler, useFormContext, Controller } from 'react-hook-form';
import {
  Box,
  Button,
  CircularProgress,
  InputAdornment,
  IconButton,
} from '@mui/material';
import { LoginForm } from '../../../../shared/domain-types';
import { TextFieldInput } from '../../../../shared/components';

type Props = {
  onSubmit: SubmitHandler<LoginForm>;
  isLoading: boolean;
};

export const FormLogin: React.FC<Props> = ({ onSubmit, isLoading }) => {
  const {
    handleSubmit,
    formState: { isValid, errors },
    control,
  } = useFormContext<LoginForm>();

  const [showPassword, setShowPassword] = useState(false);

  return (
    <form onSubmit={handleSubmit(onSubmit)}>
      <Box display="flex" flexDirection="column" gap={2} width={450}>
        <Controller
          name="email"
          control={control}
          render={({ field }) => (
            <TextFieldInput
              required
              variant="filled"
              fullWidth
              label="Email"
              type="email"
              error={Boolean(errors.email)}
              helperText={errors.email && errors.email?.message}
              {...field}
            />
          )}
        />

        <Controller
          name="password"
          control={control}
          render={({ field }) => (
            <TextFieldInput
              required
              variant="filled"
              fullWidth
              label="Senha"
              type={showPassword ? 'text' : 'password'}
              error={Boolean(errors.password)}
              helperText={errors.password && errors.password?.message}
              InputProps={{
                endAdornment: (
                  <InputAdornment position="end">
                    <IconButton
                      onClick={() => setShowPassword(!showPassword)}
                      onMouseDown={() => setShowPassword(!showPassword)}
                    >
                      {showPassword ? <Visibility /> : <VisibilityOff />}
                    </IconButton>
                  </InputAdornment>
                ),
              }}
              {...field}
            />
          )}
        />

        <Box
          sx={{ marginBottom: '1rem' }}
          width="100%"
          display="flex"
          justifyContent="center"
        >
          {isLoading ? (
            <Button
              disabled={!isValid}
              sx={{ padding: 2 }}
              fullWidth
              type="submit"
              variant="contained"
            >
              <CircularProgress
                variant="indeterminate"
                color="inherit"
                size={15}
              />
            </Button>
          ) : (
            <Button
              disabled={!isValid}
              sx={{ padding: 1 }}
              fullWidth
              type="submit"
              variant="contained"
            >
              Entrar
            </Button>
          )}
        </Box>
      </Box>
    </form>
  );
};
