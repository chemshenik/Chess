using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
[Serializable]
public class Game
{
    public string token, created, modified, status, title, avatar, description;
    public int bank, id, min_players, max_players, category, currency, prize_number;
    public double minimal_rate;
    public bool rate_fixed, use_time_params, _public, active_connect, is_side_game;
}
