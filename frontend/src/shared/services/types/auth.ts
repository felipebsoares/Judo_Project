export interface Auth {
  accessToken: string;
  user: {
    name: string;
    email: string;
  };
}
