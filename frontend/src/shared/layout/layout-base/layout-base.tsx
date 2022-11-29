import { AppBar, Box, Button, Toolbar, Typography } from '@mui/material';
import { ReactNode } from 'react';
import { useAuth } from '../../hooks';

type Props = {
  children: ReactNode;
};

export const LayoutBase: React.FC<Props> = ({ children }) => {
  const { logout } = useAuth();

  return (
    <Box
      sx={{
        backgroundColor: '#e9ecef',
      }}
    >
      <AppBar component="nav" sx={{ px: { xl: 25, sm: 1, xs: 1 } }}>
        <Toolbar>
          <Typography variant="h6" component="div" sx={{ flexGrow: 1 }}>
            Federação de Judô
          </Typography>
          <Box>
            <Button onClick={logout} sx={{ color: '#fff' }}>
              Logout
            </Button>
          </Box>
        </Toolbar>
      </AppBar>
      <Box
        component="main"
        sx={{
          px: { xl: 28, sm: 4, xs: 3 },
          py: 3,
          height: 'calc(100vh - 48px)',
        }}
      >
        <Toolbar />
        {children}
      </Box>
    </Box>
  );
};
