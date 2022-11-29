import { ThemeProvider } from '@mui/material';
import { Routes } from './routes';
import { AuthProvider } from './shared/contexts';
import { theme } from './shared/theme';

export function App() {
  return (
    <ThemeProvider theme={theme}>
      <AuthProvider>
        <Routes />
      </AuthProvider>
    </ThemeProvider>
  );
}
