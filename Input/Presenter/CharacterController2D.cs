using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace EEE
{
	[RequireComponent(typeof(Rigidbody2D))]
	[RequireComponent(typeof(SpriteRenderer))]
    public class CharacterController2D : MonoBehaviour
    {
		[SerializeField, Range(0, .3f)]
		private float movementSmoothing = .05f;
		[SerializeField] 
		private bool m_AirControl = false;
		[SerializeField]
		private bool flip;

		const float k_GroundedRadius = .2f;
		private bool _characterOnGround;
		private Vector3 m_Velocity = Vector3.zero;

		private Rigidbody2D _rigidbody2D;
		private SpriteRenderer _spriteRenderer;

		private void Awake()
		{
			_rigidbody2D = GetComponent<Rigidbody2D>();
			_spriteRenderer = GetComponent<SpriteRenderer>();
		}

		private void FixedUpdate()
		{
			_characterOnGround = true;
		}

		public void Move(float move, bool onlyFromGround = false)
		{
			if (_characterOnGround || m_AirControl)
			{
				Vector3 targetVelocity = new Vector2(move * 10f, _rigidbody2D.velocity.y);
				_rigidbody2D.velocity = Vector3.SmoothDamp(_rigidbody2D.velocity, targetVelocity, ref m_Velocity, movementSmoothing);

				if (flip)
                {
					if (move > 0)
					{
						_spriteRenderer.flipX = false;
					}
					else if (move < 0)
					{
						_spriteRenderer.flipX = true;
					}
				}
			}
		}

		public bool Jump(float jumpForce, bool onlyFromGround = true)
        {
			if (onlyFromGround)
            {
				if (_characterOnGround)
				{
					AddJumpForce(jumpForce);
					return true;
				}

				return false;
			}

			AddJumpForce(jumpForce);
			return true;
		}

		private void AddJumpForce(float force)
        {
			_characterOnGround = false;
			_rigidbody2D.AddForce(new Vector2(0f, force));
		}
	}
}