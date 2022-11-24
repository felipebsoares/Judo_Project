import { TextFieldProps } from '@mui/material';
import * as S from './material-styles';

type Props = TextFieldProps;

export const TextFieldInput: React.FC<Props> = ({ ...rest }) => {
  return <S.RedditTextField {...rest} />;
};
