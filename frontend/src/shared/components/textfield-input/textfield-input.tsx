import { TextFieldInputProps } from '../types';
import { RedditTextField } from './components';

export const TextFieldInput: React.FC<TextFieldInputProps> = ({ ...rest }) => {
  return <RedditTextField {...rest} />;
};
