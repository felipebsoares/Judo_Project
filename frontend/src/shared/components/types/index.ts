import { ComponentType, ReactNode } from 'react';

export interface PageHeaderProps {
  title: string;
  description: string;
  icon: ComponentType;
  action?: ReactNode;
}
