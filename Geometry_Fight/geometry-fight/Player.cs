using geometry_fight;
using System.Windows.Forms;

internal class Player : Moving
{
    private PictureBox playerModel;
    private int playerHealth;
    private bool goLeft;
    private bool goRight;
    private bool goUp;
    private bool goDown;
    private string facing;

    public Player(int playerHealth, string facing, int speed)
    {
        this.playerHealth = playerHealth;
        this.facing = facing;
        this.speed = speed;
    }

    public PictureBox PlayerModel
    {
        get { return playerModel; }
        set { playerModel = value; }
    }

    public int PlayerHealth
    {
        get { return playerHealth; }
        set { playerHealth = value; }
    }

    public bool GoLeft
    {
        get { return goLeft; }
        set { goLeft = value; }
    }

    public bool GoRight
    {
        get { return goRight; }
        set { goRight = value; }
    }

    public bool GoUp
    {
        get { return goUp; }
        set { goUp = value; }
    }

    public bool GoDown
    {
        get { return goDown; }
        set { goDown = value; }
    }

    public string Facing
    {
        get { return facing; }
        set { facing = value; }
    }

    public int Speed
    {
        get { return speed; }
        set { speed = value; }
    }

    // Metoda ustawiająca się w odpowiednim kierunku
    public void FaceLeft()
    {
        goLeft = true;
        facing = "left";
    }

    public void FaceRight()
    {
        goRight = true;
        facing = "right";
    }

    public void FaceUp()
    {
        goUp = true;
        facing = "up";
    }

    public void FaceDown()
    {
        goDown = true;
        facing = "down";
    }

    // Metody poruszania się
    public void MoveLeft()
    {
        playerModel.Left -= speed;
    }

    public void MoveRight()
    {
        playerModel.Left += speed;
    }

    public void MoveTop()
    {
        playerModel.Top -= speed;
    }

    public void MoveDown()
    {
        playerModel.Top += speed;
    }
}
