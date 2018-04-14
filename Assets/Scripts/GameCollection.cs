using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCollection{
    public Game[] games;

    public string collectionName;
    Game gaame;
    public override string ToString()
    {
        string result = "Game\n";
        foreach (var game in games)
        {
            result += string.Format("token: " + game.token +
        ",\nbank: " + game.bank +
        ",\nid: " + game.id +
        ",\ncreated: " + game.created +
        ",\nmodified: " + game.modified +
        ",\nrate_fixed: " + game.rate_fixed +
        ",\nminimal_rate: " + game.minimal_rate +
        ",\nstatus: " + game.status +
        ",\ntitle: " + game.title +
        ",\navatar: " + game.avatar +
        ",\nmin_players: " + game.min_players +
        ",\nmax_players: " + game.max_players +
        ",\nuse_time_params: " + game.use_time_params +
        ",\npublic: " + game._public +
        ",\ncategory: " + game.category +
        ",\ncurrency: " + game.currency +
        ",\nactive_connect: " + game.active_connect +
        ",\nis_side_game: " + game.is_side_game +
        ",\nprize_number: " + game.prize_number +
        ",\ndescription: " + game.description);
        }
        return result;
    }
}
