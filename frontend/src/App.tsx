import { ThemeProvider } from '@mui/material';
import { Routes } from './routes';
import { theme } from './shared/theme';

export function App() {
  return (
    <ThemeProvider theme={theme}>
      <Routes />
    </ThemeProvider>
  );
}
