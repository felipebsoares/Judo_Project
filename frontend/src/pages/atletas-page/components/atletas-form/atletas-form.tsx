import { Grid } from '@mui/material';
import { TextFieldInput } from '../../../../shared/components';
import { FormAtletas } from '../../../../shared/domain-types';
import { useFormContext, Controller, SubmitHandler } from 'react-hook-form';

type Props = {
  onSubmit: SubmitHandler<FormAtletas>;
  id: string;
};

export const AtletasForm: React.FC<Props> = ({ onSubmit, id }) => {
  const { handleSubmit, control } = useFormContext<FormAtletas>();

  return (
    <form onSubmit={handleSubmit(onSubmit)} id={id}>
      <Grid container spacing={2}>
        <Grid item lg={3} xs={12}>
          <Controller
            name="registroFederacao"
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
            name="registroConfederacao"
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
            name="dataNascimento"
            control={control}
            render={({ field }) => (
              <TextFieldInput
                fullWidth
                type="date"
                label="Data de Nascimento"
                variant="filled"
                {...field}
              />
            )}
          />
        </Grid>

        <Grid item lg={3} xs={12}>
          <Controller
            name="dataFiliacao"
            control={control}
            render={({ field }) => (
              <TextFieldInput
                fullWidth
                type="date"
                label="Data Filiação"
                variant="filled"
                {...field}
              />
            )}
          />
        </Grid>

        <Grid item lg={3} xs={12}>
          <Controller
            name="idAgremiacao"
            control={control}
            render={({ field }) => (
              <TextFieldInput
                fullWidth
                label="Agremiação"
                type="number"
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
            name="idCidade"
            control={control}
            render={({ field }) => (
              <TextFieldInput
                fullWidth
                label="Cidade"
                type="number"
                variant="filled"
                {...field}
              />
            )}
          />
        </Grid>
        <Grid item lg={3} xs={12}>
          <Controller
            name="idEstado"
            control={control}
            render={({ field }) => (
              <TextFieldInput
                fullWidth
                label="Estado"
                type="number"
                variant="filled"
                {...field}
              />
            )}
          />
        </Grid>

        <Grid item lg={3} xs={12}>
          <Controller
            name="idPais"
            control={control}
            render={({ field }) => (
              <TextFieldInput
                fullWidth
                label="País"
                variant="filled"
                type="number"
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
            name="dataIdentidade"
            control={control}
            render={({ field }) => (
              <TextFieldInput
                fullWidth
                label="Data de Identidade"
                variant="filled"
                type="date"
                {...field}
              />
            )}
          />
        </Grid>

        <Grid item lg={3} xs={12}>
          <Controller
            name="idEmissor"
            control={control}
            render={({ field }) => (
              <TextFieldInput
                fullWidth
                label="Emissor"
                type="number"
                variant="filled"
                {...field}
              />
            )}
          />
        </Grid>

        <Grid item lg={3} xs={12}>
          <Controller
            name="idNacionalidade"
            control={control}
            render={({ field }) => (
              <TextFieldInput
                fullWidth
                label="Nacionalidade"
                variant="filled"
                type="number"
                {...field}
              />
            )}
          />
        </Grid>

        <Grid item lg={3} xs={12}>
          <Controller
            name="idProfissaoAtleta"
            control={control}
            render={({ field }) => (
              <TextFieldInput
                fullWidth
                label="Profissão Atleta"
                variant="filled"
                type="number"
                {...field}
              />
            )}
          />
        </Grid>

        <Grid item lg={3} xs={12}>
          <Controller
            name="nomePai"
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
            name="idProfissaoPai"
            control={control}
            render={({ field }) => (
              <TextFieldInput
                fullWidth
                label="Profissão do Pai"
                variant="filled"
                type="number"
                {...field}
              />
            )}
          />
        </Grid>

        <Grid item lg={3} xs={12}>
          <Controller
            name="nomeMae"
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
            name="idProfissaoMae"
            control={control}
            render={({ field }) => (
              <TextFieldInput
                fullWidth
                label="Profissão da Mãe"
                type="number"
                variant="filled"
                {...field}
              />
            )}
          />
        </Grid>

        <Grid item lg={3} xs={12}>
          <Controller
            name="idFaixa"
            control={control}
            render={({ field }) => (
              <TextFieldInput
                fullWidth
                label="Faixa"
                variant="filled"
                type="number"
                {...field}
              />
            )}
          />
        </Grid>

        <Grid item lg={3} xs={12}>
          <Controller
            name="idSexo"
            control={control}
            render={({ field }) => (
              <TextFieldInput
                fullWidth
                label="Sexo"
                variant="filled"
                type="number"
                {...field}
              />
            )}
          />
        </Grid>

        <Grid item lg={3} xs={12}>
          <Controller
            name="idEstadoCivil"
            control={control}
            render={({ field }) => (
              <TextFieldInput
                fullWidth
                label="Estado Civil"
                variant="filled"
                type="number"
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

        {/* <Grid item lg={3} xs={12}>
          <Controller
            name="selecao"
            control={control}
            render={({ field }) => (
              <TextFieldInput
                fullWidth
                label="Seleção"
                variant="filled"
                type="number"

                {...field}
              />
            )}
          />
        </Grid> */}

        <Grid item lg={3} xs={12}>
          <Controller
            name="idCliente"
            control={control}
            render={({ field }) => (
              <TextFieldInput
                fullWidth
                label="Cliente"
                type="number"
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
