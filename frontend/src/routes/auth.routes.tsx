import { Routes, Route } from 'react-router-dom';
import { Login, Register } from '../pages';

export const AuthRoutes = () => {
  return (
    <Routes>
      <Route path="/" element={<Login />} />
      <Route path="/cadastro" element={<Register />} />
    </Routes>
  );
};
