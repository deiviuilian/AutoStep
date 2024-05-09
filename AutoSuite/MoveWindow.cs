using System;
using System.Drawing;
using System.Windows.Forms;

public class DraggableForm
{
    private Form form;
    private bool dragging = false;
    private Point dragStartPosition;

    public DraggableForm(Form form)
    {
        this.form = form;
        // Associa os eventos de mouse ao formulário
        this.form.MouseDown += Form_MouseDown;
        this.form.MouseMove += Form_MouseMove;
        this.form.MouseUp += Form_MouseUp;
    }

    private void Form_MouseDown(object sender, MouseEventArgs e)
    {
        // Verifica se o botão esquerdo do mouse foi pressionado
        if (e.Button == MouseButtons.Left)
        {
            // Define que estamos iniciando um arrasto
            dragging = true;
            // Registra a posição inicial do mouse
            dragStartPosition = new Point(e.X, e.Y);
        }
    }

    private void Form_MouseMove(object sender, MouseEventArgs e)
    {
        // Verifica se estamos atualmente arrastando e se o botão esquerdo do mouse está pressionado
        if (dragging && e.Button == MouseButtons.Left)
        {
            // Calcula o deslocamento do mouse desde a posição inicial
            int deltaX = e.X - dragStartPosition.X;
            int deltaY = e.Y - dragStartPosition.Y;
            // Move o formulário pela quantidade de deslocamento do mouse
            this.form.Location = new Point(this.form.Location.X + deltaX, this.form.Location.Y + deltaY);
        }
    }

    private void Form_MouseUp(object sender, MouseEventArgs e)
    {
        // Verifica se o botão esquerdo do mouse foi liberado
        if (e.Button == MouseButtons.Left)
        {
            // Define que não estamos mais arrastando
            dragging = false;
        }
    }
}