import { Grid } from '@mui/material';
import { TextFieldInput } from '../../../../shared/components';
import { FormAtletas } from '../../../../shared/domain-types';
import { useFormContext, Controller, SubmitHandler } from 'react-hook-form';

type Props = {
  onSubmit: SubmitHandler<FormAtletas>;
  id: string;
};

export const AtletasForm: React.FC<Props> = ({ onSubmit, id }) => {
  const {
    handleSubmit,
    formState: { isValid, errors },
    control,
  } = useFormContext<FormAtletas>();

  return (
    <form onSubmit={handleSubmit(onSubmit)} id={id}>
      <Grid container spacing={2}>
        <Grid item lg={3} xs={12}>
          <Controller
            name="registro_federacao"
            control={control}
            render={({ field }) => (
              <TextFieldInput
                fullWidth
                label="Registro Federação"
                variant="filled"
                {...field}
              />
            )}
          />
        </Grid>

        <Grid item lg={3} xs={12}>
          <Controller
            name="registro_confederacao"
            control={control}
            render={({ field }) => (
              <TextFieldInput
                fullWidth
                label="Registro Confederação"
                variant="filled"
                {...field}
              />
            )}
          />
        </Grid>
        <Grid item lg={3} xs={12}>
          <Controller
            name="nome"
            control={control}
            render={({ field }) => (
              <TextFieldInput
                fullWidth
                label="Nome"
                variant="filled"
                {...field}
              />
            )}
          />
        </Grid>
        <Grid item lg={3} xs={12}>
          <Controller
            name="data_nascimento"
            control={control}
            render={({ field }) => (
              <TextFieldInput
                fullWidth
                label="Data de Nascimento"
                variant="filled"
                {...field}
              />
            )}
          />
        </Grid>

        <Grid item lg={3} xs={12}>
          <Controller
            name="data_filiacao"
            control={control}
            render={({ field }) => (
              <TextFieldInput
                fullWidth
                label="Data Filiação"
                variant="filled"
                {...field}
              />
            )}
          />
        </Grid>

        <Grid item lg={3} xs={12}>
          <Controller
            name="agremiacao"
            control={control}
            render={({ field }) => (
              <TextFieldInput
                fullWidth
                label="Agremiação"
                variant="filled"
                {...field}
              />
            )}
          />
        </Grid>
        <Grid item lg={3} xs={12}>
          <Controller
            name="cep"
            control={control}
            render={({ field }) => (
              <TextFieldInput
                fullWidth
                label="CEP"
                variant="filled"
                {...field}
              />
            )}
          />
        </Grid>
        <Grid item lg={3} xs={12}>
          <Controller
            name="endereco"
            control={control}
            render={({ field }) => (
              <TextFieldInput
                fullWidth
                label="Endereço"
                variant="filled"
                {...field}
              />
            )}
          />
        </Grid>

        <Grid item lg={3} xs={12}>
          <Controller
            name="bairro"
            control={control}
            render={({ field }) => (
              <TextFieldInput
                fullWidth
                label="Bairro"
                variant="filled"
                {...field}
              />
            )}
          />
        </Grid>

        <Grid item lg={3} xs={12}>
          <Controller
            name="complemento"
            control={control}
            render={({ field }) => (
              <TextFieldInput
                fullWidth
                label="Complemento"
                variant="filled"
                {...field}
              />
            )}
          />
        </Grid>
        <Grid item lg={3} xs={12}>
          <Controller
            name="cidade"
            control={control}
            render={({ field }) => (
              <TextFieldInput
                fullWidth
                label="Cidade"
                variant="filled"
                {...field}
              />
            )}
          />
        </Grid>
        <Grid item lg={3} xs={12}>
          <Controller
            name="estado"
            control={control}
            render={({ field }) => (
              <TextFieldInput
                fullWidth
                label="Estado"
                variant="filled"
                {...field}
              />
            )}
          />
        </Grid>

        <Grid item lg={3} xs={12}>
          <Controller
            name="pais"
            control={control}
            render={({ field }) => (
              <TextFieldInput
                fullWidth
                label="País"
                variant="filled"
                {...field}
              />
            )}
          />
        </Grid>

        <Grid item lg={3} xs={12}>
          <Controller
            name="telefone"
            control={control}
            render={({ field }) => (
              <TextFieldInput
                fullWidth
                label="Telefone"
                variant="filled"
                {...field}
              />
            )}
          />
        </Grid>

        <Grid item lg={3} xs={12}>
          <Controller
            name="email"
            control={control}
            render={({ field }) => (
              <TextFieldInput
                fullWidth
                label="Email"
                variant="filled"
                {...field}
              />
            )}
          />
        </Grid>

        <Grid item lg={3} xs={12}>
          <Controller
            name="cpf"
            control={control}
            render={({ field }) => (
              <TextFieldInput
                fullWidth
                label="CPF"
                variant="filled"
                {...field}
              />
            )}
          />
        </Grid>

        <Grid item lg={3} xs={12}>
          <Controller
            name="identidade"
            control={control}
            render={({ field }) => (
              <TextFieldInput
                fullWidth
                label="Identidade"
                variant="filled"
                {...field}
              />
            )}
          />
        </Grid>

        <Grid item lg={3} xs={12}>
          <Controller
            name="data_de_identidade"
            control={control}
            render={({ field }) => (
              <TextFieldInput
                fullWidth
                label="Data de Identidade"
                variant="filled"
                {...field}
              />
            )}
          />
        </Grid>

        <Grid item lg={3} xs={12}>
          <Controller
            name="emissor"
            control={control}
            render={({ field }) => (
              <TextFieldInput
                fullWidth
                label="Emissor"
                variant="filled"
                {...field}
              />
            )}
          />
        </Grid>

        <Grid item lg={3} xs={12}>
          <Controller
            name="nacionalidade"
            control={control}
            render={({ field }) => (
              <TextFieldInput
                fullWidth
                label="Nacionalidade"
                variant="filled"
                {...field}
              />
            )}
          />
        </Grid>

        <Grid item lg={3} xs={12}>
          <Controller
            name="profissao_atleta"
            control={control}
            render={({ field }) => (
              <TextFieldInput
                fullWidth
                label="Profissão Atleta"
                variant="filled"
                {...field}
              />
            )}
          />
        </Grid>

        <Grid item lg={3} xs={12}>
          <Controller
            name="nome_pai"
            control={control}
            render={({ field }) => (
              <TextFieldInput
                fullWidth
                label="Nome do Pai"
                variant="filled"
                {...field}
              />
            )}
          />
        </Grid>

        <Grid item lg={3} xs={12}>
          <Controller
            name="profissao_pai"
            control={control}
            render={({ field }) => (
              <TextFieldInput
                fullWidth
                label="Profissão do Pai"
                variant="filled"
                {...field}
              />
            )}
          />
        </Grid>

        <Grid item lg={3} xs={12}>
          <Controller
            name="nome_mae"
            control={control}
            render={({ field }) => (
              <TextFieldInput
                fullWidth
                label="Nome da Mãe"
                variant="filled"
                {...field}
              />
            )}
          />
        </Grid>

        <Grid item lg={3} xs={12}>
          <Controller
            name="profissao_mae"
            control={control}
            render={({ field }) => (
              <TextFieldInput
                fullWidth
                label="Profissão da Mãe"
                variant="filled"
                {...field}
              />
            )}
          />
        </Grid>

        <Grid item lg={3} xs={12}>
          <Controller
            name="faixa"
            control={control}
            render={({ field }) => (
              <TextFieldInput
                fullWidth
                label="Faixa"
                variant="filled"
                {...field}
              />
            )}
          />
        </Grid>

        <Grid item lg={3} xs={12}>
          <Controller
            name="sexo"
            control={control}
            render={({ field }) => (
              <TextFieldInput
                fullWidth
                label="Sexo"
                variant="filled"
                {...field}
              />
            )}
          />
        </Grid>

        <Grid item lg={3} xs={12}>
          <Controller
            name="estado_civil"
            control={control}
            render={({ field }) => (
              <TextFieldInput
                fullWidth
                label="Estado Civil"
                variant="filled"
                {...field}
              />
            )}
          />
        </Grid>

        <Grid item lg={3} xs={12}>
          <Controller
            name="anotacoes"
            control={control}
            render={({ field }) => (
              <TextFieldInput
                fullWidth
                label="Anotações"
                variant="filled"
                {...field}
              />
            )}
          />
        </Grid>

        <Grid item lg={3} xs={12}>
          <Controller
            name="selecao"
            control={control}
            render={({ field }) => (
              <TextFieldInput
                fullWidth
                label="Seleção"
                variant="filled"
                {...field}
              />
            )}
          />
        </Grid>

        <Grid item lg={3} xs={12}>
          <Controller
            name="cliente"
            control={control}
            render={({ field }) => (
              <TextFieldInput
                fullWidth
                label="Cliente"
                variant="filled"
                {...field}
              />
            )}
          />
        </Grid>
      </Grid>
    </form>
  );
};
