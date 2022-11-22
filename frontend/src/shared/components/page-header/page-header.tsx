import { Typography } from '@mui/material';
import { PageHeaderProps } from '../types';
import * as S from './material-styles';

export const PageHeader: React.FC<PageHeaderProps> = ({
  description,
  icon: Icon,
  title,
  action,
}) => {
  return (
    <S.Header>
      <S.HeaderWrapping>
        <S.IconWrapper>
          <Icon />
        </S.IconWrapper>
        <div>
          <Typography variant="h6">{title}</Typography>
          <Typography variant="body1">{description}</Typography>
        </div>
      </S.HeaderWrapping>

      <div style={{ marginTop: '0.5rem' }}>{action}</div>
    </S.Header>
  );
};
