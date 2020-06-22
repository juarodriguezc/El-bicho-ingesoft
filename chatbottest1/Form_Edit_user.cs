using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Common.Cache;

namespace chatbottest1
{
    public partial class Form_Edit_user : Form
    {
        //Atributos
        ModeloUsuario usuario = new ModeloUsuario();
        int id_usuario = 0;
        bool editar = false;
        private string messageData = "Recuerde que:\n"
                + "1. Diligenciar nombre y apellido solo con caracteres alfabeticos.\n"
                + "2. Diligenciar el e-mail.\n"
                + "3. Seleccionar el cargo del nuevo usuario.\n"
                + "4. La contraseña debe tener entre 8 y 25 caracteres,\n almenos una letra mayuscula y al menos un número\n";
        public Form_Edit_user()
        {
            InitializeComponent();
        }

        private void Edit_user_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }
        private void MostrarUsuarios() {
            dataGridView1.DataSource = usuario.MostrarUsuarios(UserLoginCache.Correo);
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                txt_nombre.ReadOnly = false;
                txt_apellido.ReadOnly = false;
                txt_correo.ReadOnly = false;
                txt_contrasenia.ReadOnly = false;
                pick_fecha_nacimiento.Enabled = true;
                comboBox_genero.Enabled = true;
                comboBox_cargo.Enabled = true;
                editar = true;

                dato_erroneo_nombre.Visible = false;
                dato_erroneo_apellido.Visible = false;
                dato_erroneo_contrasenia.Visible = false;
                dato_erroneo_contrasenia.Visible = false;


                id_usuario = int.Parse(dataGridView1.CurrentRow.Cells["Id_persona"].Value.ToString());
                txt_nombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txt_apellido.Text = dataGridView1.CurrentRow.Cells["Apellido"].Value.ToString();
                txt_contrasenia.Text = dataGridView1.CurrentRow.Cells["Password"].Value.ToString();
                txt_correo.Text = dataGridView1.CurrentRow.Cells["Correo"].Value.ToString();
                txt_telefono.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
                pick_fecha_nacimiento.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells["Nacimiento"].Value.ToString());
                comboBox_cargo.SelectedItem = dataGridView1.CurrentRow.Cells["Tipo usuario"].Value.ToString();
                comboBox_genero.SelectedItem = dataGridView1.CurrentRow.Cells["Genero"].Value.ToString();
                txt_usuario.Text= dataGridView1.CurrentRow.Cells["Usuario"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione el usuario a editar");
            }
        }

        private void bt_saveuser_Click(object sender, EventArgs e)
        {
            dato_erroneo_nombre.Visible = false;
            dato_erroneo_apellido.Visible = false;
            dato_erroneo_contrasenia.Visible = false;
            dato_erroneo_contrasenia.Visible = false;
            if (editar == false)
            {
            }
            else
            {
                if (txt_nombre.Text.Length != 0 && txt_apellido.Text.Length != 0 && txt_correo.Text.Length != 0
                && comboBox_cargo.SelectedItem != null)
                {
                    //Verifica que los campos no estén vacios -- Codigo traido de Felipe Riaño
                    if (verficarNombre_Apell(txt_nombre.Text) && verficarNombre_Apell(txt_apellido.Text)
                        && verificarEmail(txt_correo.Text) && verficarPassWordL(txt_contrasenia.Text))
                    {
                        try
                        {
                            //usuario.EditarUsuario(id_usuario, txt_correo.Text, txt_nombre.Text, txt_apellido.Text, Convert.ToDateTime(pick_fecha_nacimiento.Text), txt_contrasenia.Text, comboBox_cargo.SelectedItem.ToString());
                            usuario.EditarUsuario(id_usuario, txt_correo.Text, txt_nombre.Text, txt_apellido.Text, Convert.ToDateTime(pick_fecha_nacimiento.Text), txt_contrasenia.Text, comboBox_cargo.SelectedItem.ToString(), comboBox_genero.SelectedItem.ToString(), txt_telefono.Text, txt_usuario.Text);
                            MessageBox.Show("El usuario se editó correctamente");
                            limpiarCasillas();
                            MostrarUsuarios();
                            editar = false;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("No se pudo editar los datos por: " + ex);
                        }
                    }
                    else
                    {
                        if (!verficarNombre_Apell(txt_nombre.Text)) dato_erroneo_nombre.Visible = true;
                        if (!verficarNombre_Apell(txt_apellido.Text)) dato_erroneo_apellido.Visible = true;
                        if (!verificarEmail(txt_correo.Text)) dato_erroneo_email.Visible = true;
                        if (!verficarPassWordL(txt_contrasenia.Text)) dato_erroneo_contrasenia.Visible = true;
                        DialogResult datos = MessageBox.Show("Algunos datos ingresados son incorrectos", "Datos erroneos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        MessageBox.Show(messageData, "Tener en cuenta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    DialogResult datos = MessageBox.Show("Completa los campos", "Datos erroneos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                

            }
        }

        private void limpiarCasillas()
        {

            txt_nombre.Text = "NOMBRE";
            txt_apellido.Text = "APELLIDO";
            txt_correo.Text = "CORREO";
            txt_contrasenia.Text = "CONTRASEÑA";
            txt_telefono.Text = "TELEFONO";
            txt_usuario.Text = "USUARIO";
            pick_fecha_nacimiento.Value = Convert.ToDateTime("01-01-2000");
            //comboBox_cargo.ResetText();
            txt_nombre.ReadOnly = true;
            txt_apellido.ReadOnly = true;
            txt_correo.ReadOnly = true;
            txt_contrasenia.ReadOnly = true;
            pick_fecha_nacimiento.Enabled = false;
            comboBox_cargo.Enabled = false;
            comboBox_genero.Enabled = false;

            dato_erroneo_nombre.Visible = false;
            dato_erroneo_apellido.Visible = false;
            dato_erroneo_contrasenia.Visible = false;
            dato_erroneo_contrasenia.Visible = false;
        }


        private bool verficarNombre_Apell(string nom_apell)
        {
            //Verificar no numeros
            for (int i = 0; i < nom_apell.Length; i++)
            {
                if (Char.IsDigit(nom_apell[i]) || (!Char.IsLetter(nom_apell[i]) && (!Char.IsWhiteSpace(nom_apell[i]))))
                {
                    return false;
                }
            }
            return true;

        }

        public bool verificarEmail(string email)
        {
            //Adaptación código Felipe Riaño
            //Verficiacion formato email
            //Contadores de arrobas y de puntos en la direccion del correo
            int verAt = 0, verPoint = 0, aux = 0;

            for (int i = 0; i < email.Length; i++)
            {

                if (email[i] == '@' && aux == 0)
                {
                    verAt++;
                    aux++;
                }
                else if (email[i] == '.' && aux > 0)
                {
                    verPoint++;
                }
                else if (email[i] == '@' && aux != 0)
                {
                    return false;
                }

            }
            if (verAt == 1 && verPoint > 0 && verPoint <= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool verficarPassWordL(String password)
        {
            //Verificar password, código Felipe Riaño
            if (password.Length >= 8 && password.Length <= 25)
            {

                //Contadores de mayusculas y numeros
                int cantNum = 0, cantUper = 0;

                for (int i = 0; i < password.Length; i++)
                {

                    //Verficiacion si la contraseña tiene algun caracter que no sea digito o letra
                    if (Char.IsLetter(password[i]) || Char.IsDigit(password[i]))
                    {

                        if (Char.IsUpper(password[i]))
                        {
                            cantUper++;
                        }
                        else if (Char.IsDigit(password[i]))
                        {
                            cantNum++;
                        }

                    }
                    else
                    {
                        return false;
                    }

                }

                //Verificacion contraseña con numeros y con mayusculas
                if (cantNum > 0 && cantUper > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }

    }
}
