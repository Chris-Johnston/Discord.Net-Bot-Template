# Discord.Net-Bot-Template
A template for a Discord.Net Bot. This contains only the most barebones framework
to develop a bot.

This is not intended to serve as a substitute for the offical documentation.
Please refer to the offical documentation about how the library is used.
The code in this project is based on the examples provided in the offical documenation.

## What's included:

This template includes the logic for creating a new Discord Bot, logging in with
a bot token provided in Environment Variables, and executing a `!ping` command.

Check the `docker` branch for a Dockerfile image template.

## What's not included:

This template does not include any code for:

- Use of a Database
- Dependency Injection
- Webhooks, Shards, REST-only clients, or any Discord.Net client other than `DiscordSocketClient`

## Usage

1. Click "Use this template" on this page, or [click here](https://github.com/Chris-Johnston/Discord.Net-Bot-Template/generate).
2. Clone your new repo.
3. (Optional, but recommended) Rename solution files, project files, and relative paths.
4. Set your `DiscordToken` environment variable, and run your bot.
