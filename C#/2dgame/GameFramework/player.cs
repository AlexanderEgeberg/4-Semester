using System;
using System.Collections.Generic;
using System.Text;

namespace GameFramework
{
    class player
    {
        public Position BodyPosistion { get; set; }

        public player(int bodyRow, int bodyCol)
        {
            BodyPosistion = new Position(bodyRow, bodyCol);
        }

        public void Move(InputType move)
        {
            switch (move)
            {
                case InputType.FORWARD:
                    BodyPosistion.Row--;
                    break;
                case InputType.BACK:
                    BodyPosistion.Row++;
                    break;
                case InputType.RIGHT:
                    BodyPosistion.Col++;
                    break;
                case InputType.LEFT:
                    BodyPosistion.Col--;
                    break;
            }
        }

    }
}
