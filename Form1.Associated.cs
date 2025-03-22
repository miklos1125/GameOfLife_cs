namespace GameOfLife
{
    public partial class Form1
    {
        private void CountNeighbours(Cell c)
        {
            int counter = 0;
            for (int i = c.x == 0 ? 0 : c.x - 1;
                i < ((c.x == cells.GetLength(0) - 1) ? c.x + 1 : c.x + 2);
                i++)
            {
                for (int j = c.y == 0 ? 0 : c.y - 1;
                    j < ((c.y == cells.GetLength(1) - 1) ? c.y + 1 : c.y + 2);
                    j++)
                {
                    if (i == c.x && j == c.y) continue;
                    if (cells[i, j].isAlive) counter++;
                }
            }

            if (c.isAlive)
            {
                switch (counter)
                {
                    case 0: goto case 8;
                    case 1: goto case 8;
                    case 2: break;
                    case 3: break;
                    case 4: goto case 8;
                    case 5: goto case 8;
                    case 6: goto case 8;
                    case 7: goto case 8;
                    case 8: c.SigneItToChange(); break;
                }
            }
            else
            {
                if (counter == 3) c.SigneItToChange();
            }
        }

        private void RefreshCellStructure()
        {
            for (int i = 0; i < cells.GetLength(0); i++)
            {
                for (int j = 0; j < cells.GetLength(1); j++)
                {
                    cells[i, j].ChangeIfSigned();
                }
            }
        }

        private void IslandCounting()
        {
            int counter = 0;
            for (int i = 0; i < cells.GetLength(0); i++)
            {
                for (int j = 0; j < cells.GetLength(1); j++)
                {
                    if (cells[i, j].isAlive && !cells[i, j].isSignedNotToCount)
                    {
                        counter++;
                        cells[i, j].setNoCountSign = true;
                        SearchForDistantShores(cells[i, j]);
                    }
                }
            }
            islandCounter.Text = counter.ToString();
            foreach (Cell c in cells)
            {
                c.setNoCountSign = false;
            }

            void SearchForDistantShores(Cell c)
            {
                for (int i = c.x == 0 ? 0 : c.x - 1;
                    i < ((c.x == cells.GetLength(0) - 1) ? c.x + 1 : c.x + 2);
                    i++)
                {
                    for (int j = c.y == 0 ? 0 : c.y - 1;
                        j < ((c.y == cells.GetLength(1) - 1) ? c.y + 1 : c.y + 2);
                        j++)
                    {
                        if (i == c.x && j == c.y) continue;
                        if (cells[i, j].isSignedNotToCount) continue;
                        if (cells[i, j].isAlive)
                        {
                            cells[i, j].setNoCountSign = true;
                            SearchForDistantShores(cells[i, j]);
                        }
                    }
                }
            }
        }


        private void SetNewHistory()
        {
            for (int h = 0; h < history.Length; h++)
            {
                history[h] = new bool[cells.GetLength(0)][];
                for (int i = 0; i < cells.GetLength(0); i++)
                {
                    history[h][i] = new bool[cells.GetLength(1)];
                }
            }
        }


        private bool HistoryRepeats()
        {
            //refresh history:
            for (int h = history.Length - 1; h >= 1; h--)
            {
                for (int i = 0; i < history[h].Length; i++)
                {
                    for (int j = 0; j < history[h][i].Length; j++)
                    {
                        history[h][i][j] = history[h - 1][i][j];
                    }
                }
            }
            for (int i = 0; i < cells.GetLength(0); i++)
            {
                for (int j = 0; j < cells.GetLength(1); j++)
                {
                    history[0][i][j] = cells[i, j].isAlive;
                }
            }
            //compare actual(history[0]) to last generations:
            for (int h = 1; h < history.Length; h++)
            {
                for (int i = 0; i < history[h].Length; i++)
                {
                    for (int j = 0; j < history[h][i].Length; j++)
                    {
                        if (history[0][i][j] != history[h][i][j])
                        {
                            goto cellmapend;
                        }
                    }
                }
                repeatsIn = h;
                return true; //no differences found with the actual history page,
                             //so cell structure is repeating (static). =>
                             //End program flow.

            cellmapend:;//start to compare another history page here, or end loop;
            }
            return false;
        }
    }
}
