import { ComponentType, ReactNode } from 'react';

export interface PageHeaderProps {
  title: string;
  description: string;
  icon: ComponentType;
  action?: ReactNode;
}

export type TableData = {
  name: string;
  calories: number;
  fat: number;
  carbs: number;
  protein: number;
};

export type TableProps = {
  rows: TableData[];
  removeModal: () => void;
};

export type ModalProps = {
  handleClickOpen: () => void;
  handleClose: () => void;
  open: boolean;
};

export type ConfirmModalProps = Omit<ModalProps, 'handleClickOpen'> & {
  title: string;
  message: string;
};
