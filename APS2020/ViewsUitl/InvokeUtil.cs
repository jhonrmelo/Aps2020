using System;
using System.Windows.Forms;

namespace APS2020.ViewsUitl
{
    static class InvokeUtil
    {
        /// <summary>
        /// Utilizamos esse metodo quando necessário utilizar um elemento que esteja aberto em varias abas, gerando varias threads, exemplo:
        /// Duas instancias de clientes em VS diferentes ainda é identificada como uma instancia só em threads diferentes, com o safe invoke verificamos a 
        /// thread que queremos mudar o elemento
        /// </summary>
        /// <param name="uiElement"></param>
        /// <param name="updater"></param>
        /// <param name="forceSynchronous"></param>
        public static void SafeInvoke(this Control uiElement, Action updater, bool forceSynchronous)
        {
            if (uiElement == null)
            {
                throw new ArgumentNullException("Elemento não encontrado!");
            }

            if (uiElement.InvokeRequired)
            {
                if (forceSynchronous)
                {
                    uiElement.Invoke((Action)delegate { SafeInvoke(uiElement, updater, forceSynchronous); });
                }
                else
                {
                    uiElement.BeginInvoke((Action)delegate { SafeInvoke(uiElement, updater, forceSynchronous); });
                }
            }
            else
            {
                if (uiElement.IsDisposed)
                {
                    throw new ObjectDisposedException("O elemento já foi criado!");
                }

                updater();
            }
        }
    }
}
