import { useNavigate } from 'react-router-dom';
import { Delete, Edit } from '@mui/icons-material';
import {
  IconButton,
  Paper,
  Table as TableMaterial,
  TableBody,
  TableContainer,
  TableHead,
  TableRow,
} from '@mui/material';
import * as S from './material-styles';
import { TableProps } from '../types';

export const Table: React.FC<TableProps> = ({ rows }) => {
  const navigate = useNavigate();

  return (
    <TableContainer component={Paper}>
      <TableMaterial sx={{ minWidth: 700 }} aria-label="customized table">
        <TableHead>
          <TableRow>
            <S.StyledTableCell>Dessert (100g serving)</S.StyledTableCell>
            <S.StyledTableCell align="center">Calories</S.StyledTableCell>
            <S.StyledTableCell align="center">Fat&nbsp;(g)</S.StyledTableCell>
            <S.StyledTableCell align="center">Carbs&nbsp;(g)</S.StyledTableCell>
            <S.StyledTableCell align="center">
              Protein&nbsp;(g)
            </S.StyledTableCell>
            <S.StyledTableCell align="center">Ações</S.StyledTableCell>
          </TableRow>
        </TableHead>
        <TableBody>
          {rows.map((row, index) => (
            <S.StyledTableRow key={row.name}>
              <S.StyledTableCell component="th" scope="row">
                {row.name}
              </S.StyledTableCell>
              <S.StyledTableCell align="center">
                {row.calories}
              </S.StyledTableCell>
              <S.StyledTableCell align="center">{row.fat}</S.StyledTableCell>
              <S.StyledTableCell align="center">{row.carbs}</S.StyledTableCell>
              <S.StyledTableCell align="center">
                {row.protein}
              </S.StyledTableCell>
              <S.StyledTableCell align="center">
                <IconButton size="small">
                  <Delete />
                </IconButton>
                <IconButton size="small">
                  <Edit onClick={() => navigate(`/atletas/${index}`)} />
                </IconButton>
              </S.StyledTableCell>
            </S.StyledTableRow>
          ))}
        </TableBody>
      </TableMaterial>
    </TableContainer>
  );
};
