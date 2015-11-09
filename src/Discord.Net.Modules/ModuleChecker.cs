﻿using Discord.Commands;
using Discord.Commands.Permissions;

namespace Discord.Modules
{
	public class ModuleChecker : IPermissionChecker
	{
		private readonly ModuleManager _manager;
		private readonly FilterType _filterType;

		internal ModuleChecker(ModuleManager manager)
		{
			_manager = manager;
			_filterType = manager.FilterType;
        }

		public bool CanRun(Command command, User user, Channel channel)
		{
			return _filterType == FilterType.Unrestricted || _filterType == FilterType.AllowPrivate || _manager.HasChannel(channel);
		}
	}
}
