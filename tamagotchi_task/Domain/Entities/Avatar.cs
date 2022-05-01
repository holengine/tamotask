﻿namespace tamagotchi_task.Domain.Entities
{
    public class Avatar : DomainEntity
    {
        public Character Character { get; set; }
        public List<Animal> Animals { get; set; } = new List<Animal>();
        public List<Fur> Furs { get; set; } = new List<Fur>();
        public List<Accessories> Accessories { get; set; } = new List<Accessories>();
        public List<Wallpaper> Wallpapers { get; set; } = new List<Wallpaper>();

    }
}