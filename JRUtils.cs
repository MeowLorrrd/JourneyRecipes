using Microsoft.Xna.Framework;
using Terraria;

namespace JourneyRecipes
{
    public static class JRUtils
    {
        public static Vector2 MoveTowards(this Vector2 currentPosition, Vector2 targetPosition, float maxAmountAllowedToMove)
        {
            Vector2 v = targetPosition - currentPosition;
            if (v.Length() < maxAmountAllowedToMove)
            {
                return targetPosition;
            }
            return currentPosition + v.SafeNormalize(Vector2.Zero) * maxAmountAllowedToMove;
        }
        public static float GetLerpValue(float from, float to, float t, bool clamped = false)
        {
            if (clamped)
            {
                if (from < to)
                {
                    if (t < from)
                    {
                        return 0f;
                    }
                    if (t > to)
                    {
                        return 1f;
                    }
                }
                else
                {
                    if (t < to)
                    {
                        return 1f;
                    }
                    if (t > from)
                    {
                        return 0f;
                    }
                }
            }
            return (t - from) / (to - from);
        }

        public static float Remap(float fromValue, float fromMin, float fromMax, float toMin, float toMax, bool clamped = true)
        {
            return MathHelper.Lerp(toMin, toMax, GetLerpValue(fromMin, fromMax, fromValue, clamped));
        }

        public static bool IsWorldPointSolid(Vector2 pos)
        {
            Point point = pos.ToTileCoordinates();
            if (!WorldGen.InWorld(point.X, point.Y, 1))
            {
                return false;
            }
            Tile tile = Main.tile[point.X, point.Y];
            if (tile.type == 19 || tile.type == 427 || tile.type == 435 || tile.type == 436 || tile.type == 437 || tile.type == 438 || tile.type == 439)
            {
                return false;
            }
            if (tile == null || !tile.active() || tile.inActive() || !Main.tileSolid[tile.type])
            {
                return false;
            }
            int num = tile.blockType();
            switch (num)
            {
                case 0:
                    if (pos.X >= (float)(point.X * 16) && pos.X <= (float)(point.X * 16 + 16) && pos.Y >= (float)(point.Y * 16))
                    {
                        return pos.Y <= (float)(point.Y * 16 + 16);
                    }
                    return false;
                case 1:
                    if (pos.X >= (float)(point.X * 16) && pos.X <= (float)(point.X * 16 + 16) && pos.Y >= (float)(point.Y * 16 + 8))
                    {
                        return pos.Y <= (float)(point.Y * 16 + 16);
                    }
                    return false;
                case 2:
                case 3:
                case 4:
                case 5:
                    {
                        if (pos.X < (float)(point.X * 16) && pos.X > (float)(point.X * 16 + 16) && pos.Y < (float)(point.Y * 16) && pos.Y > (float)(point.Y * 16 + 16))
                        {
                            return false;
                        }
                        float num2 = pos.X % 16f;
                        float num3 = pos.Y % 16f;
                        switch (num)
                        {
                            case 3:
                                return num2 + num3 >= 16f;
                            case 2:
                                return num3 >= num2;
                            case 5:
                                return num3 <= num2;
                            case 4:
                                return num2 + num3 <= 16f;
                        }
                        break;
                    }
            }
            return false;
        }
    }
}
