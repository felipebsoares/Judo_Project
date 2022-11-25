import { Grid } from '@mui/material';
import { TextFieldInput } from '../../../../shared/components';

export const AtletasForm: React.FC = () => {
  return (
    <form>
      <Grid container spacing={2}>
        <Grid item lg={3} xs={12}>
          <TextFieldInput fullWidth label="Name" variant="filled" />
        </Grid>

        <Grid item lg={3} xs={12}>
          <TextFieldInput fullWidth label="Senha" variant="filled" />
        </Grid>
        <Grid item lg={3} xs={12}>
          <TextFieldInput fullWidth label="Email" variant="filled" />
        </Grid>
        <Grid item lg={3} xs={12}>
          <TextFieldInput fullWidth label="Reddit" variant="filled" />
        </Grid>

        <Grid item lg={3} xs={12}>
          <TextFieldInput fullWidth label="Name" variant="filled" />
        </Grid>

        <Grid item lg={3} xs={12}>
          <TextFieldInput fullWidth label="Senha" variant="filled" />
        </Grid>
        <Grid item lg={3} xs={12}>
          <TextFieldInput fullWidth label="Email" variant="filled" />
        </Grid>
        <Grid item lg={3} xs={12}>
          <TextFieldInput fullWidth label="Reddit" variant="filled" />
        </Grid>

        <Grid item lg={3} xs={12}>
          <TextFieldInput fullWidth label="Name" variant="filled" />
        </Grid>

        <Grid item lg={3} xs={12}>
          <TextFieldInput fullWidth label="Senha" variant="filled" />
        </Grid>
        <Grid item lg={3} xs={12}>
          <TextFieldInput fullWidth label="Email" variant="filled" />
        </Grid>
        <Grid item lg={3} xs={12}>
          <TextFieldInput fullWidth label="Reddit" variant="filled" />
        </Grid>
      </Grid>
    </form>
  );
};
