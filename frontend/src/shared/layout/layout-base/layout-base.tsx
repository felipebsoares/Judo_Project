import { AppBar, Box, Button, Toolbar, Typography } from '@mui/material';
import { ReactNode } from 'react';
import * as S from './material-styles';

type Props = {
  children: ReactNode;
};

export const LayoutBase: React.FC<Props> = ({ children }) => {
  return (
    <S.LayoutWrapper>
      <AppBar component="nav" sx={{ px: { xl: 25, sm: 1, xs: 1 } }}>
        <Toolbar>
          <Typography variant="h6" component="div" sx={{ flexGrow: 1 }}>
            Federação de Judô
          </Typography>
          <Box>
            <Button sx={{ color: '#fff' }}>Logout</Button>
          </Box>
        </Toolbar>
      </AppBar>
      <Box component="main" sx={{ px: { xl: 28, sm: 4, xs: 3 }, py: 3 }}>
        <Toolbar />
        {children}
      </Box>
    </S.LayoutWrapper>
  );
};
