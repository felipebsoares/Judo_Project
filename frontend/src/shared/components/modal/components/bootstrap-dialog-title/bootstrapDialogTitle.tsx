import { Close } from '@mui/icons-material';
import { DialogTitle, IconButton } from '@mui/material';
import { DialogTitleProps } from '../../../types';

export const BootstrapDialogTitle = ({
  onClose,
  children,
  ...rest
}: DialogTitleProps) => {
  return (
    <DialogTitle sx={{ m: 0, p: 2 }} {...rest}>
      {children}
      {onClose ? (
        <IconButton
          aria-label="close"
          onClick={onClose}
          sx={{
            position: 'absolute',
            right: 8,
            top: 8,
            color: (theme) => theme.palette.grey[500],
          }}
        >
          <Close />
        </IconButton>
      ) : null}
    </DialogTitle>
  );
};
