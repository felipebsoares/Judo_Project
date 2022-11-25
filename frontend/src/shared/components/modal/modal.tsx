import { Button, DialogActions, DialogContent } from '@mui/material';
import { ModalProps } from '../types';
import { BootstrapDialogTitle } from './components';
import * as S from './styles';

export const Modal: React.FC<ModalProps> = ({
  handleClose,
  open,
  title,
  maxWidth,
  children,
  actions,
}) => {
  return (
    <S.BootstrapDialog onClose={handleClose} open={open} maxWidth={maxWidth}>
      <BootstrapDialogTitle id="customized-dialog-title" onClose={handleClose}>
        {title}
      </BootstrapDialogTitle>
      <DialogContent dividers>{children}</DialogContent>
      <DialogActions>
        <Button variant="contained" color="error" onClick={handleClose}>
          Cancelar
        </Button>
        {actions?.map((action) => action)}
      </DialogActions>
    </S.BootstrapDialog>
  );
};
