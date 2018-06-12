﻿using UnityEngine;

namespace StandardAssets.Characters.Effects
{
	/// <inheritdoc />
	public class AudioMovementEventPlayer : MovementEventPlayer
	{
		/// <summary>
		/// The audio source to be played
		/// </summary>
		[SerializeField]
		private AudioSource source;
		
		/// <inheritdoc />
		protected override void PlayMovementEvent(MovementEvent movementEvent)
		{
			source.Play();
		}
	}
}