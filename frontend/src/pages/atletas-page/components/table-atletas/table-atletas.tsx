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
import * as S from './styles';
import { TableDataRows } from './types';

export type TableProps = {
  rows: TableDataRows[];
  removeModal: () => void;
};

export const TableAtletas: React.FC<TableProps> = ({ rows, removeModal }) => {
  const navigate = useNavigate();

  return (
    <TableContainer component={Paper}>
      <TableMaterial sx={{ minWidth: 700 }} aria-label="customized table">
        <TableHead>
          <TableRow>
            <S.StyledTableCell align="center">Nome</S.StyledTableCell>
            <S.StyledTableCell align="center">
              Profissão Atleta
            </S.StyledTableCell>
            <S.StyledTableCell align="center">Seleção</S.StyledTableCell>
            <S.StyledTableCell align="center">Federação</S.StyledTableCell>
            <S.StyledTableCell align="center">Confederação</S.StyledTableCell>
            <S.StyledTableCell align="center">Ações</S.StyledTableCell>
          </TableRow>
        </TableHead>

        <TableBody>
          {rows.map((row, index) => (
            <S.StyledTableRow key={index}>
              <S.StyledTableCell align="center" component="th" scope="row">
                {row.nameAthlete}
              </S.StyledTableCell>
              <S.StyledTableCell align="center">
                {row.profession}
              </S.StyledTableCell>
              <S.StyledTableCell align="center">
                {row.selection}
              </S.StyledTableCell>
              <S.StyledTableCell align="center">
                {row.federation}
              </S.StyledTableCell>
              <S.StyledTableCell align="center">
                {row.confederation}
              </S.StyledTableCell>
              <S.StyledTableCell align="center">
                <IconButton size="small">
                  <Delete onClick={removeModal} />
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
