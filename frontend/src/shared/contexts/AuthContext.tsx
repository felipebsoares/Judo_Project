import { createContext, useCallback, useEffect, useState } from 'react';
import { api } from '../api';
import { Alert } from '../adapters';
import { AuthService } from '../services';
import { IAuthContext, IAuthProviderProps } from './types';

export const AuthContext = createContext<IAuthContext>({} as IAuthContext);

export const AuthProvider: React.FC<IAuthProviderProps> = ({ children }) => {
  const [isAuthenticated, setIsAuthenticated] = useState(false);

  useEffect(() => {
    const user = localStorage.getItem('@judo:user');
    const accessToken = localStorage.getItem('@judo:accessToken');

    if (accessToken && user) {
      api.defaults.headers.common.Authorization = `Bearer ${accessToken}`;
      setIsAuthenticated(true);
    }
  }, []);

  const login = useCallback(
    async (email: string | undefined, password: string | undefined) => {
      const result = await AuthService(email, password);

      if (result instanceof Error) {
        Alert.callError({
          title: (result as Error).name,
          description: (result as Error).message,
        });
        return;
      } else {
        localStorage.setItem('@judo:user', JSON.stringify(result.user));
        localStorage.setItem('@judo:accessToken', result.accessToken);
        api.defaults.headers.common.Authorization = `Bearer ${result.accessToken}`;
      }

      setIsAuthenticated(true);
    },
    [],
  );

  const logout = useCallback(() => {
    localStorage.removeItem('@judo:user');
    localStorage.removeItem('@judo:accessToken');

    setIsAuthenticated(false);
  }, []);

  return (
    <AuthContext.Provider value={{ login, logout, isAuthenticated }}>
      {children}
    </AuthContext.Provider>
  );
};
