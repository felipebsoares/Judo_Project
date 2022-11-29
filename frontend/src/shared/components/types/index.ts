import { Breakpoint, TextFieldProps } from '@mui/material';
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
  title: string;
  children?: ReactNode;
  maxWidth?: false | Breakpoint | undefined;
  actions?: ReactNode[];
};

export type ConfirmModalProps = Omit<
  ModalProps,
  'handleClickOpen' | 'children'
> & {
  title: string;
  message: string;
  maxWidth?: false | Breakpoint | undefined;
};

export type TextFieldInputProps = TextFieldProps;

export type DialogTitleProps = {
  id: string;
  children?: ReactNode;
  onClose: () => void;
};