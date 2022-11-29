import { forwardRef } from 'react';
import { TextFieldInputProps } from '../types';
import { RedditTextField } from './components';

export const TextFieldInput = forwardRef<HTMLInputElement, TextFieldInputProps>(
  ({ ...rest }, ref) => {
    return <RedditTextField {...rest} ref={ref} />;
  },
);
