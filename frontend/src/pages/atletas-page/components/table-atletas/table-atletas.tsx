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
import { Atletas } from '../../../../shared/services';

export type TableProps = {
  rows: Atletas[];
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
            <S.StyledTableCell align="center">CPF</S.StyledTableCell>
            <S.StyledTableCell align="center">Identidade</S.StyledTableCell>
            <S.StyledTableCell align="center">
              Registro Federação
            </S.StyledTableCell>
            <S.StyledTableCell align="center">
              Registro Confederação
            </S.StyledTableCell>
            <S.StyledTableCell align="center">Ações</S.StyledTableCell>
          </TableRow>
        </TableHead>

        <TableBody>
          {rows.map((row, index) => (
            <S.StyledTableRow key={index}>
              <S.StyledTableCell align="center" component="th" scope="row">
                {row.nome}
              </S.StyledTableCell>
              <S.StyledTableCell align="center">{row.cpf}</S.StyledTableCell>
              <S.StyledTableCell align="center">
                {row.identidade}
              </S.StyledTableCell>
              <S.StyledTableCell align="center">
                {row.registroFederacao}
              </S.StyledTableCell>
              <S.StyledTableCell align="center">
                {row.registroConfederacao}
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
