import { Routes, Route } from 'react-router-dom';
import {
  AddAgremiacaoPage,
  AddAtletasPage,
  AgremiacaoPage,
  AtletasPage,
  EditAgremiacaoPage,
  EditAtletasPage,
} from '../pages';

export function AppRoutes() {
  return (
    <Routes>
      <Route path="atletas">
        <Route index element={<AtletasPage />} />
        <Route path="cadastro" element={<AddAtletasPage />} />
        <Route path=":id" element={<EditAtletasPage />} />
      </Route>
      <Route path="agremiacao">
        <Route index element={<AgremiacaoPage />} />
        <Route path="cadastro" element={<AddAgremiacaoPage />} />
        <Route path=":id" element={<EditAgremiacaoPage />} />
      </Route>
    </Routes>
  );
}
