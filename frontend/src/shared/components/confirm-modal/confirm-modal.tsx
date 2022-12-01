import {
  Button,
  Dialog,
  DialogActions,
  DialogContent,
  DialogContentText,
  DialogTitle,
} from '@mui/material';
import { ConfirmModalProps } from '../types';

export const ConfirmModal: React.FC<ConfirmModalProps> = ({
  handleClose,
  open,
  title,
  message,
  maxWidth = 'sm',
  onConfirm,
}) => {
  return (
    <Dialog maxWidth={maxWidth} open={open} onClose={handleClose}>
      <DialogTitle sx={{ padding: '1.5rem 1.5rem 1rem 1.5rem' }}>
        {title}
      </DialogTitle>
      <DialogContent>
        <DialogContentText>{message}</DialogContentText>
      </DialogContent>
      <DialogActions sx={{ paddingBottom: '1.5rem', paddingRight: '1.5rem' }}>
        <Button variant="contained" color="error" onClick={handleClose}>
          Fechar
        </Button>
        <Button variant="contained" color="primary" onClick={onConfirm}>
          Confirmar
        </Button>
      </DialogActions>
    </Dialog>
  );
};
