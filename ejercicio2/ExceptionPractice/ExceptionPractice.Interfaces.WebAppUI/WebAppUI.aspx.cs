using ExceptionPractice.CrossCutting.Exceptions;
using ExceptionPractice.Logic.Implementations;
using System;

namespace ExceptionPractice.Interfaces.WebAppUI
{
    public partial class WebAppUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonExecute_Click(object sender, EventArgs e)
        {
            int opcion = Convert.ToInt32(ListBoxExercises.SelectedValue);
            Operations Operation = new Operations();

            switch (opcion)
            {
                case 1:
                    {
                        try //Punto 1, ingresar un Valor, Dividir por cero y generar Excepcion
                        {
                            int number = 1;
                            Operation.DivisionZero(number);
                        }
                        catch (Exception ex)
                        {
                            LabelResult.Text = "Resultado: " + ex.Message;
                        }
                        finally
                        {
                            LabelStatus.Text = "Estado: La operacion se completo";
                        }
                        break;
                    }
                case 2:
                    {
                        ListBoxOptions.Visible = true;
                        try //Punto 2, Ingresar 2 valores y generar excepciones en Division por Cero y en formato no valido
                        {
                            int number;
                            int numberTwo;
                            string phrase = "asd";
                            if (Convert.ToInt32(ListBoxOptions.SelectedValue) == 1)
                            {
                                number = 6;
                                numberTwo = 3;
                                LabelResult.Text = $"La division de {number} en {numberTwo} es: {Operation.Division(number, numberTwo)}";
                            }
                            else if (Convert.ToInt32(ListBoxOptions.SelectedValue) == 2)
                            {
                                number = 1;
                                numberTwo = 0;
                                Operation.Division(1, 0);
                            }
                            else if (Convert.ToInt32(ListBoxOptions.SelectedValue) == 3)
                            {
                                number = 1;
                                Operation.Division(1, Convert.ToInt32(phrase));
                            }
                        }
                        catch (FormatException)
                        {
                            LabelResult.Text = "Seguro Ingreso una letra o no ingreso nada!";
                        }
                        catch (Exception ex)
                        {
                            LabelResult.Text = ex.Message;
                        }
                        finally
                        {
                            LabelStatus.Text = "Estado: La operacion se completo";
                        }
                        break;
                    }
                case 3:
                    {
                        try //Punto 3, generar excepcion y mostrar el Tipo de excepcion y el Mensaje
                        {
                            Operation.ExceptionGenerator();
                        }
                        catch (Exception ex)
                        {
                            LabelResult.Text = $"Resultado: {ex.Message}";
                        }
                        finally
                        {
                            LabelStatus.Text = "Estado: La operacion se completo";
                        }
                        break;
                    }
                case 4:
                    {
                        try //Punto 4, idem al anterior pero generando una Exception personalizada
                        {
                            Operation.CustomExceptionGenerator();
                        }
                        catch (CustomException ex)
                        {
                            LabelResult.Text = $"Resultado: {ex.Message}";
                        }
                        finally
                        {
                            LabelStatus.Text = "Estado: La operacion se completo";
                        }
                        break;
                    }
            }
        }
    }
}