using System;
using System.Collections;

namespace Company.WM.BLL.Administration {
    #region Interface IUserCollection

    /// <summary>
    /// Defines size, enumerators, and synchronization methods for strongly
    /// typed collections of <see cref="User"/> elements.
    /// </summary>
    /// <remarks>
    /// <b>IUserCollection</b> provides an <see cref="ICollection"/>
    /// that is strongly typed for <see cref="User"/> elements.
    /// </remarks>

    public interface IUserCollection {
        #region Properties
        #region Count

        /// <summary>
        /// Gets the number of elements contained in the
        /// <see cref="IUserCollection"/>.
        /// </summary>
        /// <value>The number of elements contained in the
        /// <see cref="IUserCollection"/>.</value>
        /// <remarks>Please refer to <see cref="ICollection.Count"/> for details.</remarks>

        int Count { get; }

        #endregion
        #region IsSynchronized

        /// <summary>
        /// Gets a value indicating whether access to the
        /// <see cref="IUserCollection"/> is synchronized (thread-safe).
        /// </summary>
        /// <value><c>true</c> if access to the <see cref="IUserCollection"/> is
        /// synchronized (thread-safe); otherwise, <c>false</c>. The default is <c>false</c>.</value>
        /// <remarks>Please refer to <see cref="ICollection.IsSynchronized"/> for details.</remarks>

        bool IsSynchronized { get; }

        #endregion
        #region SyncRoot

        /// <summary>
        /// Gets an object that can be used to synchronize access
        /// to the <see cref="IUserCollection"/>.
        /// </summary>
        /// <value>An object that can be used to synchronize access
        /// to the <see cref="IUserCollection"/>.</value>
        /// <remarks>Please refer to <see cref="ICollection.SyncRoot"/> for details.</remarks>

        object SyncRoot { get; }

        #endregion
        #endregion
        #region Methods
        #region CopyTo

        /// <summary>
        /// Copies the entire <see cref="IUserCollection"/> to a one-dimensional <see cref="Array"/>
        /// of <see cref="User"/> elements, starting at the specified index of the target array.
        /// </summary>
        /// <param name="array">The one-dimensional <see cref="Array"/> that is the destination of the
        /// <see cref="User"/> elements copied from the <see cref="IUserCollection"/>.
        /// The <b>Array</b> must have zero-based indexing.</param>
        /// <param name="arrayIndex">The zero-based index in <paramref name="array"/>
        /// at which copying begins.</param>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="array"/> is a null reference.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="arrayIndex"/> is less than zero.</exception>
        /// <exception cref="ArgumentException"><para>
        /// <paramref name="arrayIndex"/> is equal to or greater than the length of <paramref name="array"/>.
        /// </para><para>-or-</para><para>
        /// The number of elements in the source <see cref="IUserCollection"/> is greater
        /// than the available space from <paramref name="arrayIndex"/> to the end of the destination
        /// <paramref name="array"/>.</para></exception>
        /// <remarks>Please refer to <see cref="ICollection.CopyTo"/> for details.</remarks>

        void CopyTo(User[] array, int arrayIndex);

        #endregion
        #region GetEnumerator

        /// <summary>
        /// Returns an <see cref="IUserEnumerator"/> that can
        /// iterate through the <see cref="IUserCollection"/>.
        /// </summary>
        /// <returns>An <see cref="IUserEnumerator"/>
        /// for the entire <see cref="IUserCollection"/>.</returns>
        /// <remarks>Please refer to <see cref="IEnumerable.GetEnumerator"/> for details.</remarks>

        IUserEnumerator GetEnumerator();

        #endregion
        #endregion
    }

    #endregion
    #region Interface IUserList

    /// <summary>
    /// Represents a strongly typed collection of <see cref="User"/>
    /// objects that can be individually accessed by index.
    /// </summary>
    /// <remarks>
    /// <b>IUserList</b> provides an <see cref="IList"/>
    /// that is strongly typed for <see cref="User"/> elements.
    /// </remarks>

    public interface
        IUserList: IUserCollection {
        #region Properties
        #region IsFixedSize

        /// <summary>
        /// Gets a value indicating whether the <see cref="IUserList"/> has a fixed size.
        /// </summary>
        /// <value><c>true</c> if the <see cref="IUserList"/> has a fixed size;
        /// otherwise, <c>false</c>. The default is <c>false</c>.</value>
        /// <remarks>Please refer to <see cref="IList.IsFixedSize"/> for details.</remarks>

        bool IsFixedSize { get; }

        #endregion
        #region IsReadOnly

        /// <summary>
        /// Gets a value indicating whether the <see cref="IUserList"/> is read-only.
        /// </summary>
        /// <value><c>true</c> if the <see cref="IUserList"/> is read-only;
        /// otherwise, <c>false</c>. The default is <c>false</c>.</value>
        /// <remarks>Please refer to <see cref="IList.IsReadOnly"/> for details.</remarks>

        bool IsReadOnly { get; }

        #endregion
        #region Item

        /// <summary>
        /// Gets or sets the <see cref="User"/> element at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the
        /// <see cref="User"/> element to get or set.</param>
        /// <value>
        /// The <see cref="User"/> element at the specified <paramref name="index"/>.
        /// </value>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <para><paramref name="index"/> is less than zero.</para>
        /// <para>-or-</para>
        /// <para><paramref name="index"/> is equal to or greater than
        /// <see cref="IUserCollection.Count"/>.</para>
        /// </exception>
        /// <exception cref="NotSupportedException">
        /// The property is set and the <see cref="IUserList"/> is read-only.</exception>
        /// <remarks>Please refer to <see cref="IList.this"/> for details.</remarks>

        User this[int index] { get; set; }

        #endregion
        #endregion
        #region Methods
        #region Add

        /// <summary>
        /// Adds a <see cref="User"/> to the end
        /// of the <see cref="IUserList"/>.
        /// </summary>
        /// <param name="value">The <see cref="User"/> object
        /// to be added to the end of the <see cref="IUserList"/>.
        /// This argument can be a null reference.
        /// </param>
        /// <returns>The <see cref="IUserList"/> index at which
        /// the <paramref name="value"/> has been added.</returns>
        /// <exception cref="NotSupportedException">
        /// <para>The <see cref="IUserList"/> is read-only.</para>
        /// <para>-or-</para>
        /// <para>The <b>IUserList</b> has a fixed size.</para></exception>
        /// <remarks>Please refer to <see cref="IList.Add"/> for details.</remarks>

        int Add(User value);

        #endregion
        #region Clear

        /// <summary>
        /// Removes all elements from the <see cref="IUserList"/>.
        /// </summary>
        /// <exception cref="NotSupportedException">
        /// <para>The <see cref="IUserList"/> is read-only.</para>
        /// <para>-or-</para>
        /// <para>The <b>IUserList</b> has a fixed size.</para></exception>
        /// <remarks>Please refer to <see cref="IList.Clear"/> for details.</remarks>

        void Clear();

        #endregion
        #region Contains

        /// <summary>
        /// Determines whether the <see cref="IUserList"/>
        /// contains the specified <see cref="User"/> element.
        /// </summary>
        /// <param name="value">The <see cref="User"/> object
        /// to locate in the <see cref="IUserList"/>.
        /// This argument can be a null reference.
        /// </param>
        /// <returns><c>true</c> if <paramref name="value"/> is found in the
        /// <see cref="IUserList"/>; otherwise, <c>false</c>.</returns>
        /// <remarks>Please refer to <see cref="IList.Contains"/> for details.</remarks>

        bool Contains(User value);

        #endregion
        #region IndexOf

        /// <summary>
        /// Returns the zero-based index of the first occurrence of the specified
        /// <see cref="User"/> in the <see cref="IUserList"/>.
        /// </summary>
        /// <param name="value">The <see cref="User"/> object
        /// to locate in the <see cref="IUserList"/>.
        /// This argument can be a null reference.
        /// </param>
        /// <returns>
        /// The zero-based index of the first occurrence of <paramref name="value"/>
        /// in the <see cref="IUserList"/>, if found; otherwise, -1.
        /// </returns>
        /// <remarks>Please refer to <see cref="IList.IndexOf"/> for details.</remarks>

        int IndexOf(User value);

        #endregion
        #region Insert

        /// <summary>
        /// Inserts a <see cref="User"/> element into the
        /// <see cref="IUserList"/> at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index at which
        /// <paramref name="value"/> should be inserted.</param>
        /// <param name="value">The <see cref="User"/> object
        /// to insert into the <see cref="IUserList"/>.
        /// This argument can be a null reference.
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <para><paramref name="index"/> is less than zero.</para>
        /// <para>-or-</para>
        /// <para><paramref name="index"/> is greater than
        /// <see cref="IUserCollection.Count"/>.</para>
        /// </exception>
        /// <exception cref="NotSupportedException">
        /// <para>The <see cref="IUserList"/> is read-only.</para>
        /// <para>-or-</para>
        /// <para>The <b>IUserList</b> has a fixed size.</para></exception>
        /// <remarks>Please refer to <see cref="IList.Insert"/> for details.</remarks>

        void Insert(int index, User value);

        #endregion
        #region Remove

        /// <summary>
        /// Removes the first occurrence of the specified <see cref="User"/>
        /// from the <see cref="IUserList"/>.
        /// </summary>
        /// <param name="value">The <see cref="User"/> object
        /// to remove from the <see cref="IUserList"/>.
        /// This argument can be a null reference.
        /// </param>
        /// <exception cref="NotSupportedException">
        /// <para>The <see cref="IUserList"/> is read-only.</para>
        /// <para>-or-</para>
        /// <para>The <b>IUserList</b> has a fixed size.</para></exception>
        /// <remarks>Please refer to <see cref="IList.Remove"/> for details.</remarks>

        void Remove(User value);

        #endregion
        #region RemoveAt

        /// <summary>
        /// Removes the element at the specified index of the
        /// <see cref="IUserList"/>.
        /// </summary>
        /// <param name="index">The zero-based index of the element to remove.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <para><paramref name="index"/> is less than zero.</para>
        /// <para>-or-</para>
        /// <para><paramref name="index"/> is equal to or greater than
        /// <see cref="IUserCollection.Count"/>.</para>
        /// </exception>
        /// <exception cref="NotSupportedException">
        /// <para>The <see cref="IUserList"/> is read-only.</para>
        /// <para>-or-</para>
        /// <para>The <b>IUserList</b> has a fixed size.</para></exception>
        /// <remarks>Please refer to <see cref="IList.RemoveAt"/> for details.</remarks>

        void RemoveAt(int index);

        #endregion
        #endregion
    }

    #endregion
    #region Interface IUserEnumerator

    /// <summary>
    /// Supports type-safe iteration over a collection that
    /// contains <see cref="User"/> elements.
    /// </summary>
    /// <remarks>
    /// <b>IUserEnumerator</b> provides an <see cref="IEnumerator"/>
    /// that is strongly typed for <see cref="User"/> elements.
    /// </remarks>

    public interface IUserEnumerator {
        #region Properties
        #region Current

        /// <summary>
        /// Gets the current <see cref="User"/> element in the collection.
        /// </summary>
        /// <value>The current <see cref="User"/> element in the collection.</value>
        /// <exception cref="InvalidOperationException"><para>The enumerator is positioned
        /// before the first element of the collection or after the last element.</para>
        /// <para>-or-</para>
        /// <para>The collection was modified after the enumerator was created.</para></exception>
        /// <remarks>Please refer to <see cref="IEnumerator.Current"/> for details, but note
        /// that <b>Current</b> fails if the collection was modified since the last successful
        /// call to <see cref="MoveNext"/> or <see cref="Reset"/>.</remarks>

        User Current { get; }

        #endregion
        #endregion
        #region Methods
        #region MoveNext

        /// <summary>
        /// Advances the enumerator to the next element of the collection.
        /// </summary>
        /// <returns><c>true</c> if the enumerator was successfully advanced to the next element;
        /// <c>false</c> if the enumerator has passed the end of the collection.</returns>
        /// <exception cref="InvalidOperationException">
        /// The collection was modified after the enumerator was created.</exception>
        /// <remarks>Please refer to <see cref="IEnumerator.MoveNext"/> for details.</remarks>

        bool MoveNext();

        #endregion
        #region Reset

        /// <summary>
        /// Sets the enumerator to its initial position,
        /// which is before the first element in the collection.
        /// </summary>
        /// <exception cref="InvalidOperationException">
        /// The collection was modified after the enumerator was created.</exception>
        /// <remarks>Please refer to <see cref="IEnumerator.Reset"/> for details.</remarks>

        void Reset();

        #endregion
        #endregion
    }

    #endregion
    #region Class UserCollection

    /// <summary>
    /// Implements a strongly typed collection of <see cref="User"/> elements.
    /// </summary>
    /// <remarks><para>
    /// <b>UserCollection</b> provides an <see cref="ArrayList"/>
    /// that is strongly typed for <see cref="User"/> elements.
    /// </para></remarks>

    [Serializable]
    public class UserCollection:
        IUserList, IList, ICloneable {
        #region Private Fields

        private const int _defaultCapacity = 16;

        private User[] _array = null;
        private int _count = 0;

        [NonSerialized]
        private int _version = 0;

        #endregion
        #region Private Constructors

        // helper type to identify private ctor
        private enum Tag { Default }

        private UserCollection(Tag tag) { }

        #endregion
        #region Public Constructors
        #region UserCollection()

        /// <overloads>
        /// Initializes a new instance of the <see cref="UserCollection"/> class.
        /// </overloads>
        /// <summary>
        /// Initializes a new instance of the <see cref="UserCollection"/> class
        /// that is empty and has the default initial capacity.
        /// </summary>
        /// <remarks>Please refer to <see cref="ArrayList()"/> for details.</remarks>

        public UserCollection() {
            this._array = new User[_defaultCapacity];
        }

        #endregion
        #region UserCollection(Int32)

        /// <summary>
        /// Initializes a new instance of the <see cref="UserCollection"/> class
        /// that is empty and has the specified initial capacity.
        /// </summary>
        /// <param name="capacity">The number of elements that the new
        /// <see cref="UserCollection"/> is initially capable of storing.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="capacity"/> is less than zero.</exception>
        /// <remarks>Please refer to <see cref="ArrayList(Int32)"/> for details.</remarks>

        public UserCollection(int capacity) {
            if (capacity < 0)
                throw new ArgumentOutOfRangeException("capacity",
                    capacity, "Argument cannot be negative.");

            this._array = new User[capacity];
        }

        #endregion
        #region UserCollection(UserCollection)

        /// <summary>
        /// Initializes a new instance of the <see cref="UserCollection"/> class
        /// that contains elements copied from the specified collection and
        /// that has the same initial capacity as the number of elements copied.
        /// </summary>
        /// <param name="collection">The <see cref="UserCollection"/>
        /// whose elements are copied to the new collection.</param>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="collection"/> is a null reference.</exception>
        /// <remarks>Please refer to <see cref="ArrayList(ICollection)"/> for details.</remarks>

        public UserCollection(UserCollection collection) {
            if (collection == null)
                throw new ArgumentNullException("collection");

            this._array = new User[collection.Count];
            AddRange(collection);
        }

        #endregion
        #region UserCollection(User[])

        /// <summary>
        /// Initializes a new instance of the <see cref="UserCollection"/> class
        /// that contains elements copied from the specified <see cref="User"/>
        /// array and that has the same initial capacity as the number of elements copied.
        /// </summary>
        /// <param name="array">An <see cref="Array"/> of <see cref="User"/>
        /// elements that are copied to the new collection.</param>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="array"/> is a null reference.</exception>
        /// <remarks>Please refer to <see cref="ArrayList(ICollection)"/> for details.</remarks>

        public UserCollection(User[] array) {
            if (array == null)
                throw new ArgumentNullException("array");

            this._array = new User[array.Length];
            AddRange(array);
        }

        #endregion
        #endregion
        #region Protected Properties
        #region InnerArray
        
        /// <summary>
        /// Gets the list of elements contained in the <see cref="UserCollection"/> instance.
        /// </summary>
        /// <value>
        /// A one-dimensional <see cref="Array"/> with zero-based indexing that contains all 
        /// <see cref="User"/> elements in the <see cref="UserCollection"/>.
        /// </value>
        /// <remarks>
        /// Use <b>InnerArray</b> to access the element array of a <see cref="UserCollection"/>
        /// instance that might be a read-only or synchronized wrapper. This is necessary because
        /// the element array field of wrapper classes is always a null reference.
        /// </remarks>

        protected virtual User[] InnerArray {
            get { return this._array; }
        }

        #endregion
        #endregion
        #region Public Properties
        #region Capacity

        /// <summary>
        /// Gets or sets the capacity of the <see cref="UserCollection"/>.
        /// </summary>
        /// <value>The number of elements that the
        /// <see cref="UserCollection"/> can contain.</value>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <b>Capacity</b> is set to a value that is less than <see cref="Count"/>.</exception>
        /// <remarks>Please refer to <see cref="ArrayList.Capacity"/> for details.</remarks>

        public virtual int Capacity {
            get { return this._array.Length; }
            set {
                if (value == this._array.Length) return;

                if (value < this._count)
                    throw new ArgumentOutOfRangeException("Capacity",
                        value, "Value cannot be less than Count.");

                if (value == 0) {
                    this._array = new User[_defaultCapacity];
                    return;
                }

                User[] newArray = new User[value];
                Array.Copy(this._array, newArray, this._count);
                this._array = newArray;
            }
        }

        #endregion
        #region Count

        /// <summary>
        /// Gets the number of elements contained in the <see cref="UserCollection"/>.
        /// </summary>
        /// <value>
        /// The number of elements contained in the <see cref="UserCollection"/>.
        /// </value>
        /// <remarks>Please refer to <see cref="ArrayList.Count"/> for details.</remarks>

        public virtual int Count {
            get { return this._count; }
        }

        #endregion
        #region IsFixedSize

        /// <summary>
        /// Gets a value indicating whether the <see cref="UserCollection"/> has a fixed size.
        /// </summary>
        /// <value><c>true</c> if the <see cref="UserCollection"/> has a fixed size;
        /// otherwise, <c>false</c>. The default is <c>false</c>.</value>
        /// <remarks>Please refer to <see cref="ArrayList.IsFixedSize"/> for details.</remarks>

        public virtual bool IsFixedSize {
            get { return false; }
        }

        #endregion
        #region IsReadOnly

        /// <summary>
        /// Gets a value indicating whether the <see cref="UserCollection"/> is read-only.
        /// </summary>
        /// <value><c>true</c> if the <see cref="UserCollection"/> is read-only;
        /// otherwise, <c>false</c>. The default is <c>false</c>.</value>
        /// <remarks>Please refer to <see cref="ArrayList.IsReadOnly"/> for details.</remarks>

        public virtual bool IsReadOnly {
            get { return false; }
        }

        #endregion
        #region IsSynchronized

        /// <summary>
        /// Gets a value indicating whether access to the <see cref="UserCollection"/>
        /// is synchronized (thread-safe).
        /// </summary>
        /// <value><c>true</c> if access to the <see cref="UserCollection"/> is
        /// synchronized (thread-safe); otherwise, <c>false</c>. The default is <c>false</c>.</value>
        /// <remarks>Please refer to <see cref="ArrayList.IsSynchronized"/> for details.</remarks>

        public virtual bool IsSynchronized {
            get { return false; }
        }

        #endregion
		#region IsUnique

		/// <summary>
		/// Gets a value indicating whether the <see cref="UserCollection"/> 
		/// ensures that all elements are unique.
		/// </summary>
		/// <value>
		/// <c>true</c> if the <see cref="UserCollection"/> ensures that all 
		/// elements are unique; otherwise, <c>false</c>. The default is <c>false</c>.
		/// </value>
		/// <remarks>
		/// <b>IsUnique</b> returns <c>true</c> exactly if the <see cref="UserCollection"/>
		/// is exposed through a <see cref="Unique"/> wrapper. 
		/// Please refer to <see cref="Unique"/> for details.
		/// </remarks>

		public virtual bool IsUnique {
			get { return false; }
		}

		#endregion
        #region Item: User

        /// <summary>
        /// Gets or sets the <see cref="User"/> element at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the
        /// <see cref="User"/> element to get or set.</param>
        /// <value>
        /// The <see cref="User"/> element at the specified <paramref name="index"/>.
        /// </value>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <para><paramref name="index"/> is less than zero.</para>
        /// <para>-or-</para>
        /// <para><paramref name="index"/> is equal to or greater than <see cref="Count"/>.</para>
        /// </exception>
        /// <exception cref="NotSupportedException"><para>
        /// The property is set and the <see cref="UserCollection"/> is read-only.
        /// </para><para>-or-</para><para>
        /// The property is set, the <b>UserCollection</b> already contains the
        /// specified element at a different index, and the <b>UserCollection</b>
        /// ensures that all elements are unique.</para></exception>
        /// <remarks>Please refer to <see cref="ArrayList.this"/> for details.</remarks>

        public virtual User this[int index] {
            get {
                ValidateIndex(index);
                return this._array[index];
            }
            set {
                ValidateIndex(index);
                ++this._version;
                this._array[index] = value;
            }
        }

        #endregion
        #region IList.Item: Object

        /// <summary>
        /// Gets or sets the element at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index of the element to get or set.</param>
        /// <value>
        /// The element at the specified <paramref name="index"/>. When the property
        /// is set, this value must be compatible with <see cref="User"/>.
        /// </value>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <para><paramref name="index"/> is less than zero.</para>
        /// <para>-or-</para>
        /// <para><paramref name="index"/> is equal to or greater than <see cref="Count"/>.</para>
        /// </exception>
        /// <exception cref="InvalidCastException">The property is set to a value
        /// that is not compatible with <see cref="User"/>.</exception>
        /// <exception cref="NotSupportedException"><para>
        /// The property is set and the <see cref="UserCollection"/> is read-only.
        /// </para><para>-or-</para><para>
        /// The property is set, the <b>UserCollection</b> already contains the
        /// specified element at a different index, and the <b>UserCollection</b>
        /// ensures that all elements are unique.</para></exception>
        /// <remarks>Please refer to <see cref="ArrayList.this"/> for details.</remarks>

        object IList.this[int index] {
            get { return this[index]; }
            set { this[index] = (User) value; }
        }

        #endregion
        #region SyncRoot

        /// <summary>
        /// Gets an object that can be used to synchronize
        /// access to the <see cref="UserCollection"/>.
        /// </summary>
        /// <value>An object that can be used to synchronize
        /// access to the <see cref="UserCollection"/>.
        /// </value>
        /// <remarks>Please refer to <see cref="ArrayList.SyncRoot"/> for details.</remarks>

        public virtual object SyncRoot {
            get { return this; }
        }

        #endregion
        #endregion
        #region Public Methods
        #region Add(User)

        /// <summary>
        /// Adds a <see cref="User"/> to the end of the <see cref="UserCollection"/>.
        /// </summary>
        /// <param name="value">The <see cref="User"/> object
        /// to be added to the end of the <see cref="UserCollection"/>.
        /// This argument can be a null reference.
        /// </param>
        /// <returns>The <see cref="UserCollection"/> index at which the
        /// <paramref name="value"/> has been added.</returns>
        /// <exception cref="NotSupportedException">
        /// <para>The <see cref="UserCollection"/> is read-only.</para>
        /// <para>-or-</para>
        /// <para>The <b>UserCollection</b> has a fixed size.</para>
        /// <para>-or-</para>
        /// <para>The <b>UserCollection</b> already contains the specified
        /// <paramref name="value"/>, and the <b>UserCollection</b>
        /// ensures that all elements are unique.</para></exception>
        /// <remarks>Please refer to <see cref="ArrayList.Add"/> for details.</remarks>

        public virtual int Add(User value) {
            if (this._count == this._array.Length)
                EnsureCapacity(this._count + 1);

            ++this._version;
            this._array[this._count] = value;
            return this._count++;
        }

        #endregion
        #region IList.Add(Object)

        /// <summary>
        /// Adds an <see cref="Object"/> to the end of the <see cref="UserCollection"/>.
        /// </summary>
        /// <param name="value">
        /// The object to be added to the end of the <see cref="UserCollection"/>.
        /// This argument must be compatible with <see cref="User"/>.
        /// This argument can be a null reference.
        /// </param>
        /// <returns>The <see cref="UserCollection"/> index at which the
        /// <paramref name="value"/> has been added.</returns>
        /// <exception cref="InvalidCastException"><paramref name="value"/>
        /// is not compatible with <see cref="User"/>.</exception>
        /// <exception cref="NotSupportedException">
        /// <para>The <see cref="UserCollection"/> is read-only.</para>
        /// <para>-or-</para>
        /// <para>The <b>UserCollection</b> has a fixed size.</para>
        /// <para>-or-</para>
        /// <para>The <b>UserCollection</b> already contains the specified
        /// <paramref name="value"/>, and the <b>UserCollection</b>
        /// ensures that all elements are unique.</para></exception>
        /// <remarks>Please refer to <see cref="ArrayList.Add"/> for details.</remarks>

        int IList.Add(object value) {
            return Add((User) value);
        }

        #endregion
        #region AddRange(UserCollection)

        /// <overloads>
        /// Adds a range of elements to the end of the <see cref="UserCollection"/>.
        /// </overloads>
        /// <summary>
        /// Adds the elements of another collection to the end of the <see cref="UserCollection"/>.
        /// </summary>
        /// <param name="collection">The <see cref="UserCollection"/> whose elements
        /// should be added to the end of the current collection.</param>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="collection"/> is a null reference.</exception>
        /// <exception cref="NotSupportedException">
        /// <para>The <see cref="UserCollection"/> is read-only.</para>
        /// <para>-or-</para>
        /// <para>The <b>UserCollection</b> has a fixed size.</para>
        /// <para>-or-</para>
        /// <para>The <b>UserCollection</b> already contains one or more elements
        /// in the specified <paramref name="collection"/>, and the <b>UserCollection</b>
        /// ensures that all elements are unique.</para></exception>
        /// <remarks>Please refer to <see cref="ArrayList.AddRange"/> for details.</remarks>

        public virtual void AddRange(UserCollection collection) {
            if (collection == null)
                throw new ArgumentNullException("collection");

            if (collection.Count == 0) return;
            if (this._count + collection.Count > this._array.Length)
                EnsureCapacity(this._count + collection.Count);

            ++this._version;
            Array.Copy(collection.InnerArray, 0,
                this._array, this._count, collection.Count);
            this._count += collection.Count;
        }

        #endregion
        #region AddRange(User[])

        /// <summary>
        /// Adds the elements of a <see cref="User"/> array
        /// to the end of the <see cref="UserCollection"/>.
        /// </summary>
        /// <param name="array">An <see cref="Array"/> of <see cref="User"/> elements
        /// that should be added to the end of the <see cref="UserCollection"/>.</param>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="array"/> is a null reference.</exception>
        /// <exception cref="NotSupportedException">
        /// <para>The <see cref="UserCollection"/> is read-only.</para>
        /// <para>-or-</para>
        /// <para>The <b>UserCollection</b> has a fixed size.</para>
        /// <para>-or-</para>
        /// <para>The <b>UserCollection</b> already contains one or more elements
        /// in the specified <paramref name="array"/>, and the <b>UserCollection</b>
        /// ensures that all elements are unique.</para></exception>
        /// <remarks>Please refer to <see cref="ArrayList.AddRange"/> for details.</remarks>

        public virtual void AddRange(User[] array) {
            if (array == null)
                throw new ArgumentNullException("array");

            if (array.Length == 0) return;
            if (this._count + array.Length > this._array.Length)
                EnsureCapacity(this._count + array.Length);

            ++this._version;
            Array.Copy(array, 0, this._array, this._count, array.Length);
            this._count += array.Length;
        }

        #endregion
        #region BinarySearch

        /// <summary>
        /// Searches the entire sorted <see cref="UserCollection"/> for an
        /// <see cref="User"/> element using the default comparer
        /// and returns the zero-based index of the element.
        /// </summary>
        /// <param name="value">The <see cref="User"/> object
        /// to locate in the <see cref="UserCollection"/>.
        /// This argument can be a null reference.
        /// </param>
        /// <returns>The zero-based index of <paramref name="value"/> in the sorted
        /// <see cref="UserCollection"/>, if <paramref name="value"/> is found;
        /// otherwise, a negative number, which is the bitwise complement of the index
        /// of the next element that is larger than <paramref name="value"/> or, if there
        /// is no larger element, the bitwise complement of <see cref="Count"/>.</returns>
        /// <exception cref="InvalidOperationException">
        /// Neither <paramref name="value"/> nor the elements of the <see cref="UserCollection"/>
        /// implement the <see cref="IComparable"/> interface.</exception>
        /// <remarks>Please refer to <see cref="ArrayList.BinarySearch"/> for details.</remarks>

        public virtual int BinarySearch(User value) {
            return Array.BinarySearch(this._array, 0, this._count, value);
        }

        #endregion
        #region Clear

        /// <summary>
        /// Removes all elements from the <see cref="UserCollection"/>.
        /// </summary>
        /// <exception cref="NotSupportedException">
        /// <para>The <see cref="UserCollection"/> is read-only.</para>
        /// <para>-or-</para>
        /// <para>The <b>UserCollection</b> has a fixed size.</para></exception>
        /// <remarks>Please refer to <see cref="ArrayList.Clear"/> for details.</remarks>

        public virtual void Clear() {
            if (this._count == 0) return;

            ++this._version;
            Array.Clear(this._array, 0, this._count);
            this._count = 0;
        }

        #endregion
        #region Clone

        /// <summary>
        /// Creates a shallow copy of the <see cref="UserCollection"/>.
        /// </summary>
        /// <returns>A shallow copy of the <see cref="UserCollection"/>.</returns>
        /// <remarks>Please refer to <see cref="ArrayList.Clone"/> for details.</remarks>

        public virtual object Clone() {
            UserCollection collection = new UserCollection(this._count);

            Array.Copy(this._array, 0, collection._array, 0, this._count);
            collection._count = this._count;
            collection._version = this._version;

            return collection;
        }

        #endregion
        #region Contains(User)

        /// <summary>
        /// Determines whether the <see cref="UserCollection"/>
        /// contains the specified <see cref="User"/> element.
        /// </summary>
        /// <param name="value">The <see cref="User"/> object
        /// to locate in the <see cref="UserCollection"/>.
        /// This argument can be a null reference.
        /// </param>
        /// <returns><c>true</c> if <paramref name="value"/> is found in the
        /// <see cref="UserCollection"/>; otherwise, <c>false</c>.</returns>
        /// <remarks>Please refer to <see cref="ArrayList.Contains"/> for details.</remarks>

        public bool Contains(User value) {
            return (IndexOf(value) >= 0);
        }

        #endregion
        #region IList.Contains(Object)

        /// <summary>
        /// Determines whether the <see cref="UserCollection"/> contains the specified element.
        /// </summary>
        /// <param name="value">The object to locate in the <see cref="UserCollection"/>.
        /// This argument must be compatible with <see cref="User"/>.
        /// This argument can be a null reference.
        /// </param>
        /// <returns><c>true</c> if <paramref name="value"/> is found in the
        /// <see cref="UserCollection"/>; otherwise, <c>false</c>.</returns>
        /// <exception cref="InvalidCastException"><paramref name="value"/>
        /// is not compatible with <see cref="User"/>.</exception>
        /// <remarks>Please refer to <see cref="ArrayList.Contains"/> for details.</remarks>

        bool IList.Contains(object value) {
            return Contains((User) value);
        }

        #endregion
        #region CopyTo(User[])

        /// <overloads>
        /// Copies the <see cref="UserCollection"/> or a portion of it to a one-dimensional array.
        /// </overloads>
        /// <summary>
        /// Copies the entire <see cref="UserCollection"/> to a one-dimensional <see cref="Array"/>
        /// of <see cref="User"/> elements, starting at the beginning of the target array.
        /// </summary>
        /// <param name="array">The one-dimensional <see cref="Array"/> that is the destination of the
        /// <see cref="User"/> elements copied from the <see cref="UserCollection"/>.
        /// The <b>Array</b> must have zero-based indexing.</param>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="array"/> is a null reference.</exception>
        /// <exception cref="ArgumentException">
        /// The number of elements in the source <see cref="UserCollection"/> is greater
        /// than the available space in the destination <paramref name="array"/>.</exception>
        /// <remarks>Please refer to <see cref="ArrayList.CopyTo"/> for details.</remarks>

        public virtual void CopyTo(User[] array) {
            CheckTargetArray(array, 0);
            Array.Copy(this._array, array, this._count);
        }

        #endregion
        #region CopyTo(User[], Int32)

        /// <summary>
        /// Copies the entire <see cref="UserCollection"/> to a one-dimensional <see cref="Array"/>
        /// of <see cref="User"/> elements, starting at the specified index of the target array.
        /// </summary>
        /// <param name="array">The one-dimensional <see cref="Array"/> that is the destination of the
        /// <see cref="User"/> elements copied from the <see cref="UserCollection"/>.
        /// The <b>Array</b> must have zero-based indexing.</param>
        /// <param name="arrayIndex">The zero-based index in <paramref name="array"/>
        /// at which copying begins.</param>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="array"/> is a null reference.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="arrayIndex"/> is less than zero.</exception>
        /// <exception cref="ArgumentException"><para>
        /// <paramref name="arrayIndex"/> is equal to or greater than the length of <paramref name="array"/>.
        /// </para><para>-or-</para><para>
        /// The number of elements in the source <see cref="UserCollection"/> is greater than the
        /// available space from <paramref name="arrayIndex"/> to the end of the destination
        /// <paramref name="array"/>.</para></exception>
        /// <remarks>Please refer to <see cref="ArrayList.CopyTo"/> for details.</remarks>

        public virtual void CopyTo(User[] array, int arrayIndex) {
            CheckTargetArray(array, arrayIndex);
            Array.Copy(this._array, 0, array, arrayIndex, this._count);
        }

        #endregion
        #region ICollection.CopyTo(Array, Int32)

        /// <summary>
        /// Copies the entire <see cref="UserCollection"/> to a one-dimensional <see cref="Array"/>,
        /// starting at the specified index of the target array.
        /// </summary>
        /// <param name="array">The one-dimensional <see cref="Array"/> that is the destination of the
        /// <see cref="User"/> elements copied from the <see cref="UserCollection"/>.
        /// The <b>Array</b> must have zero-based indexing.</param>
        /// <param name="arrayIndex">The zero-based index in <paramref name="array"/>
        /// at which copying begins.</param>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="array"/> is a null reference.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="arrayIndex"/> is less than zero.</exception>
        /// <exception cref="ArgumentException"><para>
        /// <paramref name="array"/> is multidimensional.
        /// </para><para>-or-</para><para>
        /// <paramref name="arrayIndex"/> is equal to or greater than the length of <paramref name="array"/>.
        /// </para><para>-or-</para><para>
        /// The number of elements in the source <see cref="UserCollection"/> is greater than the
        /// available space from <paramref name="arrayIndex"/> to the end of the destination
        /// <paramref name="array"/>.</para></exception>
        /// <exception cref="InvalidCastException">
        /// The <see cref="User"/> type cannot be cast automatically
        /// to the type of the destination <paramref name="array"/>.</exception>
        /// <remarks>Please refer to <see cref="ArrayList.CopyTo"/> for details.</remarks>

        void ICollection.CopyTo(Array array, int arrayIndex) {
            CheckTargetArray(array, arrayIndex);
            CopyTo((User[]) array, arrayIndex);
        }

        #endregion
        #region GetEnumerator: IUserEnumerator

        /// <summary>
        /// Returns an <see cref="IUserEnumerator"/> that can
        /// iterate through the <see cref="UserCollection"/>.
        /// </summary>
        /// <returns>An <see cref="IUserEnumerator"/>
        /// for the entire <see cref="UserCollection"/>.</returns>
        /// <remarks>Please refer to <see cref="ArrayList.GetEnumerator"/> for details.</remarks>

        public virtual IUserEnumerator GetEnumerator() {
            return new Enumerator(this);
        }

        #endregion
        #region IEnumerable.GetEnumerator: IEnumerator

        /// <summary>
        /// Returns an <see cref="IEnumerator"/> that can
        /// iterate through the <see cref="UserCollection"/>.
        /// </summary>
        /// <returns>An <see cref="IEnumerator"/>
        /// for the entire <see cref="UserCollection"/>.</returns>
        /// <remarks>Please refer to <see cref="ArrayList.GetEnumerator"/> for details.</remarks>

        IEnumerator IEnumerable.GetEnumerator() {
            return (IEnumerator) GetEnumerator();
        }

        #endregion
        #region IndexOf(User)

        /// <summary>
        /// Returns the zero-based index of the first occurrence of the specified
        /// <see cref="User"/> in the <see cref="UserCollection"/>.
        /// </summary>
        /// <param name="value">The <see cref="User"/> object
        /// to locate in the <see cref="UserCollection"/>.
        /// This argument can be a null reference.
        /// </param>
        /// <returns>
        /// The zero-based index of the first occurrence of <paramref name="value"/>
        /// in the <see cref="UserCollection"/>, if found; otherwise, -1.
        /// </returns>
        /// <remarks>Please refer to <see cref="ArrayList.IndexOf"/> for details.</remarks>

        public virtual int IndexOf(User value) {
            return Array.IndexOf(this._array, value, 0, this._count);
        }

        #endregion
        #region IList.IndexOf(Object)

        /// <summary>
        /// Returns the zero-based index of the first occurrence of the specified
        /// <see cref="Object"/> in the <see cref="UserCollection"/>.
        /// </summary>
        /// <param name="value">The object to locate in the <see cref="UserCollection"/>.
        /// This argument must be compatible with <see cref="User"/>.
        /// This argument can be a null reference.
        /// </param>
        /// <returns>
        /// The zero-based index of the first occurrence of <paramref name="value"/>
        /// in the <see cref="UserCollection"/>, if found; otherwise, -1.
        /// </returns>
        /// <exception cref="InvalidCastException"><paramref name="value"/>
        /// is not compatible with <see cref="User"/>.</exception>
        /// <remarks>Please refer to <see cref="ArrayList.IndexOf"/> for details.</remarks>

        int IList.IndexOf(object value) {
            return IndexOf((User) value);
        }

        #endregion
        #region Insert(Int32, User)

        /// <summary>
        /// Inserts a <see cref="User"/> element into the
        /// <see cref="UserCollection"/> at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index at which <paramref name="value"/>
        /// should be inserted.</param>
        /// <param name="value">The <see cref="User"/> object
        /// to insert into the <see cref="UserCollection"/>.
        /// This argument can be a null reference.
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <para><paramref name="index"/> is less than zero.</para>
        /// <para>-or-</para>
        /// <para><paramref name="index"/> is greater than <see cref="Count"/>.</para>
        /// </exception>
        /// <exception cref="NotSupportedException">
        /// <para>The <see cref="UserCollection"/> is read-only.</para>
        /// <para>-or-</para>
        /// <para>The <b>UserCollection</b> has a fixed size.</para>
        /// <para>-or-</para>
        /// <para>The <b>UserCollection</b> already contains the specified
        /// <paramref name="value"/>, and the <b>UserCollection</b>
        /// ensures that all elements are unique.</para></exception>
        /// <remarks>Please refer to <see cref="ArrayList.Insert"/> for details.</remarks>

        public virtual void Insert(int index, User value) {
            if (index < 0)
                throw new ArgumentOutOfRangeException("index",
                    index, "Argument cannot be negative.");

            if (index > this._count)
                throw new ArgumentOutOfRangeException("index",
                    index, "Argument cannot exceed Count.");

            if (this._count == this._array.Length)
                EnsureCapacity(this._count + 1);

            ++this._version;
            if (index < this._count)
                Array.Copy(this._array, index,
                    this._array, index + 1, this._count - index);

            this._array[index] = value;
            ++this._count;
        }

        #endregion
        #region IList.Insert(Int32, Object)

        /// <summary>
        /// Inserts an element into the <see cref="UserCollection"/> at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index at which <paramref name="value"/>
        /// should be inserted.</param>
        /// <param name="value">The object to insert into the <see cref="UserCollection"/>.
        /// This argument must be compatible with <see cref="User"/>.
        /// This argument can be a null reference.
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <para><paramref name="index"/> is less than zero.</para>
        /// <para>-or-</para>
        /// <para><paramref name="index"/> is greater than <see cref="Count"/>.</para>
        /// </exception>
        /// <exception cref="InvalidCastException"><paramref name="value"/>
        /// is not compatible with <see cref="User"/>.</exception>
        /// <exception cref="NotSupportedException">
        /// <para>The <see cref="UserCollection"/> is read-only.</para>
        /// <para>-or-</para>
        /// <para>The <b>UserCollection</b> has a fixed size.</para>
        /// <para>-or-</para>
        /// <para>The <b>UserCollection</b> already contains the specified
        /// <paramref name="value"/>, and the <b>UserCollection</b>
        /// ensures that all elements are unique.</para></exception>
        /// <remarks>Please refer to <see cref="ArrayList.Insert"/> for details.</remarks>

        void IList.Insert(int index, object value) {
            Insert(index, (User) value);
        }

        #endregion
        #region ReadOnly

        /// <summary>
        /// Returns a read-only wrapper for the specified <see cref="UserCollection"/>.
        /// </summary>
        /// <param name="collection">The <see cref="UserCollection"/> to wrap.</param>
        /// <returns>A read-only wrapper around <paramref name="collection"/>.</returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="collection"/> is a null reference.</exception>
        /// <remarks>Please refer to <see cref="ArrayList.ReadOnly"/> for details.</remarks>

        public static UserCollection ReadOnly(UserCollection collection) {
            if (collection == null)
                throw new ArgumentNullException("collection");

            return new ReadOnlyList(collection);
        }

        #endregion
        #region Remove(User)

        /// <summary>
        /// Removes the first occurrence of the specified <see cref="User"/>
        /// from the <see cref="UserCollection"/>.
        /// </summary>
        /// <param name="value">The <see cref="User"/> object
        /// to remove from the <see cref="UserCollection"/>.
        /// This argument can be a null reference.
        /// </param>
        /// <exception cref="NotSupportedException">
        /// <para>The <see cref="UserCollection"/> is read-only.</para>
        /// <para>-or-</para>
        /// <para>The <b>UserCollection</b> has a fixed size.</para></exception>
        /// <remarks>Please refer to <see cref="ArrayList.Remove"/> for details.</remarks>

        public virtual void Remove(User value) {
            int index = IndexOf(value);
            if (index >= 0) RemoveAt(index);
        }

        #endregion
        #region IList.Remove(Object)

        /// <summary>
        /// Removes the first occurrence of the specified <see cref="Object"/>
        /// from the <see cref="UserCollection"/>.
        /// </summary>
        /// <param name="value">The object to remove from the <see cref="UserCollection"/>.
        /// This argument must be compatible with <see cref="User"/>.
        /// This argument can be a null reference.
        /// </param>
        /// <exception cref="InvalidCastException"><paramref name="value"/>
        /// is not compatible with <see cref="User"/>.</exception>
        /// <exception cref="NotSupportedException">
        /// <para>The <see cref="UserCollection"/> is read-only.</para>
        /// <para>-or-</para>
        /// <para>The <b>UserCollection</b> has a fixed size.</para></exception>
        /// <remarks>Please refer to <see cref="ArrayList.Remove"/> for details.</remarks>

        void IList.Remove(object value) {
            Remove((User) value);
        }

        #endregion
        #region RemoveAt

        /// <summary>
        /// Removes the element at the specified index of the <see cref="UserCollection"/>.
        /// </summary>
        /// <param name="index">The zero-based index of the element to remove.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <para><paramref name="index"/> is less than zero.</para>
        /// <para>-or-</para>
        /// <para><paramref name="index"/> is equal to or greater than <see cref="Count"/>.</para>
        /// </exception>
        /// <exception cref="NotSupportedException">
        /// <para>The <see cref="UserCollection"/> is read-only.</para>
        /// <para>-or-</para>
        /// <para>The <b>UserCollection</b> has a fixed size.</para></exception>
        /// <remarks>Please refer to <see cref="ArrayList.RemoveAt"/> for details.</remarks>

        public virtual void RemoveAt(int index) {
            ValidateIndex(index);

            ++this._version;
            if (index < --this._count)
                Array.Copy(this._array, index + 1,
                    this._array, index, this._count - index);

            this._array[this._count] = null;
        }

        #endregion
        #region RemoveRange

        /// <summary>
        /// Removes the specified range of elements from the <see cref="UserCollection"/>.
        /// </summary>
        /// <param name="index">The zero-based starting index of the range
        /// of elements to remove.</param>
        /// <param name="count">The number of elements to remove.</param>
        /// <exception cref="ArgumentException">
        /// <paramref name="index"/> and <paramref name="count"/> do not denote a
        /// valid range of elements in the <see cref="UserCollection"/>.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <para><paramref name="index"/> is less than zero.</para>
        /// <para>-or-</para>
        /// <para><paramref name="count"/> is less than zero.</para>
        /// </exception>
        /// <exception cref="NotSupportedException">
        /// <para>The <see cref="UserCollection"/> is read-only.</para>
        /// <para>-or-</para>
        /// <para>The <b>UserCollection</b> has a fixed size.</para></exception>
        /// <remarks>Please refer to <see cref="ArrayList.RemoveRange"/> for details.</remarks>

        public virtual void RemoveRange(int index, int count) {
            if (index < 0)
                throw new ArgumentOutOfRangeException("index",
                    index, "Argument cannot be negative.");

            if (count < 0)
                throw new ArgumentOutOfRangeException("count",
                    count, "Argument cannot be negative.");

            if (index + count > this._count)
                throw new ArgumentException(
                    "Arguments denote invalid range of elements.");

            if (count == 0) return;

            ++this._version;
            this._count -= count;

            if (index < this._count)
                Array.Copy(this._array, index + count,
                    this._array, index, this._count - index);

            Array.Clear(this._array, this._count, count);
        }

        #endregion
        #region Reverse()

        /// <overloads>
        /// Reverses the order of the elements in the 
        /// <see cref="UserCollection"/> or a portion of it.
        /// </overloads>
        /// <summary>
        /// Reverses the order of the elements in the entire <see cref="UserCollection"/>.
        /// </summary>
        /// <exception cref="NotSupportedException">
        /// The <see cref="UserCollection"/> is read-only.</exception>
        /// <remarks>Please refer to <see cref="ArrayList.Reverse"/> for details.</remarks>

        public virtual void Reverse() {
           if (this._count <= 1) return;
           ++this._version;
           Array.Reverse(this._array, 0, this._count);
        }

        #endregion
        #region Reverse(Int32, Int32)

        /// <summary>
        /// Reverses the order of the elements in the specified range.
        /// </summary>
        /// <param name="index">The zero-based starting index of the range
        /// of elements to reverse.</param>
        /// <param name="count">The number of elements to reverse.</param>
        /// <exception cref="ArgumentException">
        /// <paramref name="index"/> and <paramref name="count"/> do not denote a
        /// valid range of elements in the <see cref="UserCollection"/>.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <para><paramref name="index"/> is less than zero.</para>
        /// <para>-or-</para>
        /// <para><paramref name="count"/> is less than zero.</para>
        /// </exception>
        /// <exception cref="NotSupportedException">
        /// The <see cref="UserCollection"/> is read-only.</exception>
        /// <remarks>Please refer to <see cref="ArrayList.Reverse"/> for details.</remarks>

        public virtual void Reverse(int index, int count) {
            if (index < 0)
                throw new ArgumentOutOfRangeException("index",
                    index, "Argument cannot be negative.");

            if (count < 0)
                throw new ArgumentOutOfRangeException("count",
                    count, "Argument cannot be negative.");

            if (index + count > this._count)
                throw new ArgumentException(
                    "Arguments denote invalid range of elements.");

           if (count <= 1 || this._count <= 1) return;
           ++this._version;
           Array.Reverse(this._array, index, count);
        }

        #endregion
        #region Sort()

        /// <overloads>
        /// Sorts the elements in the <see cref="UserCollection"/> or a portion of it.
        /// </overloads>
        /// <summary>
        /// Sorts the elements in the entire <see cref="UserCollection"/>
        /// using the <see cref="IComparable"/> implementation of each element.
        /// </summary>
        /// <exception cref="NotSupportedException">
        /// The <see cref="UserCollection"/> is read-only.</exception>
        /// <remarks>Please refer to <see cref="ArrayList.Sort"/> for details.</remarks>

        public virtual void Sort() {
            if (this._count <= 1) return;
            ++this._version;
            Array.Sort(this._array, 0, this._count);
        }

        #endregion
        #region Sort(IComparer)

        /// <summary>
        /// Sorts the elements in the entire <see cref="UserCollection"/>
        /// using the specified <see cref="IComparer"/> interface.
        /// </summary>
        /// <param name="comparer">
        /// <para>The <see cref="IComparer"/> implementation to use when comparing elements.</para>
        /// <para>-or-</para>
        /// <para>A null reference to use the <see cref="IComparable"/> implementation 
        /// of each element.</para></param>
        /// <exception cref="NotSupportedException">
        /// The <see cref="UserCollection"/> is read-only.</exception>
        /// <remarks>Please refer to <see cref="ArrayList.Sort"/> for details.</remarks>

        public virtual void Sort(IComparer comparer) {
            if (this._count <= 1) return;
            ++this._version;
            Array.Sort(this._array, 0, this._count, comparer);
        }

        #endregion
        #region Sort(Int32, Int32, IComparer)

        /// <summary>
        /// Sorts the elements in the specified range 
        /// using the specified <see cref="IComparer"/> interface.
        /// </summary>
        /// <param name="index">The zero-based starting index of the range
        /// of elements to sort.</param>
        /// <param name="count">The number of elements to sort.</param>
        /// <param name="comparer">
        /// <para>The <see cref="IComparer"/> implementation to use when comparing elements.</para>
        /// <para>-or-</para>
        /// <para>A null reference to use the <see cref="IComparable"/> implementation 
        /// of each element.</para></param>
        /// <exception cref="ArgumentException">
        /// <paramref name="index"/> and <paramref name="count"/> do not denote a
        /// valid range of elements in the <see cref="UserCollection"/>.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <para><paramref name="index"/> is less than zero.</para>
        /// <para>-or-</para>
        /// <para><paramref name="count"/> is less than zero.</para>
        /// </exception>
        /// <exception cref="NotSupportedException">
        /// The <see cref="UserCollection"/> is read-only.</exception>
        /// <remarks>Please refer to <see cref="ArrayList.Sort"/> for details.</remarks>

        public virtual void Sort(int index, int count, IComparer comparer) {
            if (index < 0)
                throw new ArgumentOutOfRangeException("index",
                    index, "Argument cannot be negative.");

            if (count < 0)
                throw new ArgumentOutOfRangeException("count",
                    count, "Argument cannot be negative.");

            if (index + count > this._count)
                throw new ArgumentException(
                    "Arguments denote invalid range of elements.");

           if (count <= 1 || this._count <= 1) return;
            ++this._version;
            Array.Sort(this._array, index, count, comparer);
        }

        #endregion
        #region Synchronized

        /// <summary>
        /// Returns a synchronized (thread-safe) wrapper
        /// for the specified <see cref="UserCollection"/>.
        /// </summary>
        /// <param name="collection">The <see cref="UserCollection"/> to synchronize.</param>
        /// <returns>
        /// A synchronized (thread-safe) wrapper around <paramref name="collection"/>.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="collection"/> is a null reference.</exception>
        /// <remarks>Please refer to <see cref="ArrayList.Synchronized"/> for details.</remarks>

        public static UserCollection Synchronized(UserCollection collection) {
            if (collection == null)
                throw new ArgumentNullException("collection");

            return new SyncList(collection);
        }

        #endregion
        #region ToArray

        /// <summary>
        /// Copies the elements of the <see cref="UserCollection"/> to a new
        /// <see cref="Array"/> of <see cref="User"/> elements.
        /// </summary>
        /// <returns>A one-dimensional <see cref="Array"/> of <see cref="User"/>
        /// elements containing copies of the elements of the <see cref="UserCollection"/>.</returns>
        /// <remarks>Please refer to <see cref="ArrayList.ToArray"/> for details.</remarks>

        public virtual User[] ToArray() {
            User[] array = new User[this._count];
            Array.Copy(this._array, array, this._count);
            return array;
        }

        #endregion
        #region TrimToSize

        /// <summary>
        /// Sets the capacity to the actual number of elements in the <see cref="UserCollection"/>.
        /// </summary>
        /// <exception cref="NotSupportedException">
        /// <para>The <see cref="UserCollection"/> is read-only.</para>
        /// <para>-or-</para>
        /// <para>The <b>UserCollection</b> has a fixed size.</para></exception>
        /// <remarks>Please refer to <see cref="ArrayList.TrimToSize"/> for details.</remarks>

        public virtual void TrimToSize() {
            Capacity = this._count;
        }

        #endregion
        #region Unique

        /// <summary>
        /// Returns a wrapper for the specified <see cref="UserCollection"/>
        /// ensuring that all elements are unique.
        /// </summary>
        /// <param name="collection">The <see cref="UserCollection"/> to wrap.</param>    
        /// <returns>
        /// A wrapper around <paramref name="collection"/> ensuring that all elements are unique.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// <paramref name="collection"/> contains duplicate elements.</exception>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="collection"/> is a null reference.</exception>
        /// <remarks><para>
        /// The <b>Unique</b> wrapper provides a set-like collection by ensuring
        /// that all elements in the <see cref="UserCollection"/> are unique.
        /// </para><para>
        /// <b>Unique</b> raises an <see cref="ArgumentException"/> if the specified 
        /// <paramref name="collection"/> contains any duplicate elements. The returned
        /// wrapper raises a <see cref="NotSupportedException"/> whenever the user attempts 
        /// to add an element that is already contained in the <b>UserCollection</b>.
        /// </para><para>
        /// <strong>Note:</strong> The <b>Unique</b> wrapper reflects any changes made
        /// to the underlying <paramref name="collection"/>, including the possible
        /// creation of duplicate elements. The uniqueness of all elements is therefore
        /// no longer assured if the underlying collection is manipulated directly.
        /// </para></remarks>

        public static UserCollection Unique(UserCollection collection) {
            if (collection == null)
                throw new ArgumentNullException("collection");

            for (int i = collection.Count - 1; i > 0; i--)
                if (collection.IndexOf(collection[i]) < i)
                    throw new ArgumentException("collection",
                        "Argument cannot contain duplicate elements.");

            return new UniqueList(collection);
        }

        #endregion
        #endregion
        #region Private Methods
        #region CheckEnumIndex

        private void CheckEnumIndex(int index) {
            if (index < 0 || index >= this._count)
                throw new InvalidOperationException(
                    "Enumerator is not on a collection element.");
        }

        #endregion
        #region CheckEnumVersion

        private void CheckEnumVersion(int version) {
            if (version != this._version)
                throw new InvalidOperationException(
                    "Enumerator invalidated by modification to collection.");
        }

        #endregion
        #region CheckTargetArray

        private void CheckTargetArray(Array array, int arrayIndex) {
            if (array == null)
                throw new ArgumentNullException("array");
            if (array.Rank > 1)
                throw new ArgumentException(
                    "Argument cannot be multidimensional.", "array");

            if (arrayIndex < 0)
                throw new ArgumentOutOfRangeException("arrayIndex",
                    arrayIndex, "Argument cannot be negative.");
            if (arrayIndex >= array.Length)
                throw new ArgumentException(
                    "Argument must be less than array length.", "arrayIndex");

            if (this._count > array.Length - arrayIndex)
                throw new ArgumentException(
                    "Argument section must be large enough for collection.", "array");
        }

        #endregion
        #region EnsureCapacity

        private void EnsureCapacity(int minimum) {
            int newCapacity = (this._array.Length == 0 ?
                _defaultCapacity : this._array.Length * 2);

            if (newCapacity < minimum) newCapacity = minimum;
            Capacity = newCapacity;
        }

        #endregion
        #region ValidateIndex

        private void ValidateIndex(int index) {
            if (index < 0)
                throw new ArgumentOutOfRangeException("index",
                    index, "Argument cannot be negative.");

            if (index >= this._count)
                throw new ArgumentOutOfRangeException("index",
                    index, "Argument must be less than Count.");
        }

        #endregion
        #endregion
        #region Class Enumerator

        [Serializable]
        private sealed class Enumerator:
            IUserEnumerator, IEnumerator {
            #region Private Fields

            private readonly UserCollection _collection;
            private readonly int _version;
            private int _index;

            #endregion
            #region Internal Constructors

            internal Enumerator(UserCollection collection) {
                this._collection = collection;
                this._version = collection._version;
                this._index = -1;
            }

            #endregion
            #region Public Properties

            public User Current {
                get {
                    this._collection.CheckEnumIndex(this._index);
                    this._collection.CheckEnumVersion(this._version);
                    return this._collection[this._index];
                }
            }

            object IEnumerator.Current {
                get { return Current; }
            }

            #endregion
            #region Public Methods

            public bool MoveNext() {
                this._collection.CheckEnumVersion(this._version);
                return (++this._index < this._collection.Count);
            }

            public void Reset() {
                this._collection.CheckEnumVersion(this._version);
                this._index = -1;
            }

            #endregion
        }

        #endregion
        #region Class ReadOnlyList

        [Serializable]
        private sealed class ReadOnlyList: UserCollection {
            #region Private Fields

            private UserCollection _collection;

            #endregion
            #region Internal Constructors

            internal ReadOnlyList(UserCollection collection):
                base(Tag.Default) {
                this._collection = collection;
            }

            #endregion
            #region Protected Properties

            protected override User[] InnerArray {
                get { return this._collection.InnerArray; }
            }

            #endregion
            #region Public Properties

            public override int Capacity {
                get { return this._collection.Capacity; }
                set { throw new NotSupportedException(
                        "Read-only collections cannot be modified."); }
            }

            public override int Count {
                get { return this._collection.Count; }
            }

            public override bool IsFixedSize {
                get { return true; }
            }

            public override bool IsReadOnly {
                get { return true; }
            }

            public override bool IsSynchronized {
                get { return this._collection.IsSynchronized; }
            }

            public override bool IsUnique {
                get { return this._collection.IsUnique; }
            }

            public override User this[int index] {
                get { return this._collection[index]; }
                set { throw new NotSupportedException(
                        "Read-only collections cannot be modified."); }
            }

            public override object SyncRoot {
                get { return this._collection.SyncRoot; }
            }

            #endregion
            #region Public Methods

            public override int Add(User value) {
                throw new NotSupportedException(
                    "Read-only collections cannot be modified.");
            }

            public override void AddRange(UserCollection collection) {
                throw new NotSupportedException(
                    "Read-only collections cannot be modified.");
            }

            public override void AddRange(User[] array) {
                throw new NotSupportedException(
                    "Read-only collections cannot be modified.");
            }

            public override int BinarySearch(User value) {
                return this._collection.BinarySearch(value);
            }

            public override void Clear() {
                throw new NotSupportedException(
                    "Read-only collections cannot be modified.");
            }

            public override object Clone() {
                return new ReadOnlyList((UserCollection) this._collection.Clone());
            }

            public override void CopyTo(User[] array) {
                this._collection.CopyTo(array);
            }

            public override void CopyTo(User[] array, int arrayIndex) {
                this._collection.CopyTo(array, arrayIndex);
            }

            public override IUserEnumerator GetEnumerator() {
                return this._collection.GetEnumerator();
            }

            public override int IndexOf(User value) {
                return this._collection.IndexOf(value);
            }

            public override void Insert(int index, User value) {
                throw new NotSupportedException(
                    "Read-only collections cannot be modified.");
            }

            public override void Remove(User value) {
                throw new NotSupportedException(
                    "Read-only collections cannot be modified.");
            }

            public override void RemoveAt(int index) {
                throw new NotSupportedException(
                    "Read-only collections cannot be modified.");
            }

            public override void RemoveRange(int index, int count) {
                throw new NotSupportedException(
                    "Read-only collections cannot be modified.");
            }

            public override void Reverse() {
                throw new NotSupportedException(
                    "Read-only collections cannot be modified.");
            }

            public override void Reverse(int index, int count) {
                throw new NotSupportedException(
                    "Read-only collections cannot be modified.");
            }

            public override void Sort() {
                throw new NotSupportedException(
                    "Read-only collections cannot be modified.");
            }

            public override void Sort(IComparer comparer) {
                throw new NotSupportedException(
                    "Read-only collections cannot be modified.");
            }

            public override void Sort(int index, int count, IComparer comparer) {
                throw new NotSupportedException(
                    "Read-only collections cannot be modified.");
            }

            public override User[] ToArray() {
                return this._collection.ToArray();
            }

            public override void TrimToSize() {
                throw new NotSupportedException(
                    "Read-only collections cannot be modified.");
            }

            #endregion
        }

        #endregion
        #region Class SyncList

        [Serializable]
        private sealed class SyncList: UserCollection {
            #region Private Fields

            private UserCollection _collection;
            private object _root;

            #endregion
            #region Internal Constructors

            internal SyncList(UserCollection collection):
                base(Tag.Default) {

                this._root = collection.SyncRoot;
                this._collection = collection;
            }

            #endregion
            #region Protected Properties

            protected override User[] InnerArray {
                get { lock (this._root) return this._collection.InnerArray; }
            }

            #endregion
            #region Public Properties

            public override int Capacity {
                get { lock (this._root) return this._collection.Capacity; }
                set { lock (this._root) this._collection.Capacity = value; }
            }

            public override int Count {
                get { lock (this._root) return this._collection.Count; }
            }

            public override bool IsFixedSize {
                get { return this._collection.IsFixedSize; }
            }

            public override bool IsReadOnly {
                get { return this._collection.IsReadOnly; }
            }

            public override bool IsSynchronized {
                get { return true; }
            }

            public override bool IsUnique {
                get { return this._collection.IsUnique; }
            }

            public override User this[int index] {
                get { lock (this._root) return this._collection[index]; }
                set { lock (this._root) this._collection[index] = value;  }
            }

            public override object SyncRoot {
                get { return this._root; }
            }

            #endregion
            #region Public Methods

            public override int Add(User value) {
                lock (this._root) return this._collection.Add(value);
            }

            public override void AddRange(UserCollection collection) {
                lock (this._root) this._collection.AddRange(collection);
            }

            public override void AddRange(User[] array) {
                lock (this._root) this._collection.AddRange(array);
            }

            public override int BinarySearch(User value) {
                lock (this._root) return this._collection.BinarySearch(value);
            }

            public override void Clear() {
                lock (this._root) this._collection.Clear();
            }

            public override object Clone() {
                lock (this._root)
                    return new SyncList((UserCollection) this._collection.Clone());
            }

            public override void CopyTo(User[] array) {
                lock (this._root) this._collection.CopyTo(array);
            }

            public override void CopyTo(User[] array, int arrayIndex) {
                lock (this._root) this._collection.CopyTo(array, arrayIndex);
            }

            public override IUserEnumerator GetEnumerator() {
                lock (this._root) return this._collection.GetEnumerator();
            }

            public override int IndexOf(User value) {
                lock (this._root) return this._collection.IndexOf(value);
            }

            public override void Insert(int index, User value) {
                lock (this._root) this._collection.Insert(index, value);
            }

            public override void Remove(User value) {
                lock (this._root) this._collection.Remove(value);
            }

            public override void RemoveAt(int index) {
                lock (this._root) this._collection.RemoveAt(index);
            }

            public override void RemoveRange(int index, int count) {
                lock (this._root) this._collection.RemoveRange(index, count);
            }

            public override void Reverse() {
                lock (this._root) this._collection.Reverse();
            }

            public override void Reverse(int index, int count) {
                lock (this._root) this._collection.Reverse(index, count);
            }

            public override void Sort() {
                lock (this._root) this._collection.Sort();
            }

            public override void Sort(IComparer comparer) {
                lock (this._root) this._collection.Sort(comparer);
            }

            public override void Sort(int index, int count, IComparer comparer) {
                lock (this._root) this._collection.Sort(index, count, comparer);
            }

            public override User[] ToArray() {
                lock (this._root) return this._collection.ToArray();
            }

            public override void TrimToSize() {
                lock (this._root) this._collection.TrimToSize();
            }

            #endregion
        }

        #endregion
        #region Class UniqueList

        [Serializable]
        private sealed class UniqueList: UserCollection {
            #region Private Fields

            private UserCollection _collection;

            #endregion
            #region Internal Constructors

            internal UniqueList(UserCollection collection):
                base(Tag.Default) {
                this._collection = collection;
            }

            #endregion
            #region Protected Properties

            protected override User[] InnerArray {
                get { return this._collection.InnerArray; }
            }

            #endregion
            #region Public Properties

            public override int Capacity {
                get { return this._collection.Capacity; }
                set { this._collection.Capacity = value; }
            }

            public override int Count {
                get { return this._collection.Count; }
            }

            public override bool IsFixedSize {
                get { return this._collection.IsFixedSize; }
            }

            public override bool IsReadOnly {
                get { return this._collection.IsReadOnly; }
            }

            public override bool IsSynchronized {
                get { return this._collection.IsSynchronized; }
            }

            public override bool IsUnique {
                get { return true; }
            }

            public override User this[int index] {
                get { return this._collection[index]; }
                set {
                    CheckUnique(index, value);
                    this._collection[index] = value;
                }
            }

            public override object SyncRoot {
                get { return this._collection.SyncRoot; }
            }

            #endregion
            #region Public Methods

            public override int Add(User value) {
                CheckUnique(value);
                return this._collection.Add(value);
            }

            public override void AddRange(UserCollection collection) {
                foreach (User value in collection)
                    CheckUnique(value);
            
                this._collection.AddRange(collection);
            }

            public override void AddRange(User[] array) {
                foreach (User value in array)
                    CheckUnique(value);
            
                this._collection.AddRange(array);
            }

            public override int BinarySearch(User value) {
                return this._collection.BinarySearch(value);
            }

            public override void Clear() {
                this._collection.Clear();
            }

            public override object Clone() {
                return new UniqueList((UserCollection) this._collection.Clone());
            }

            public override void CopyTo(User[] array) {
                this._collection.CopyTo(array);
            }

            public override void CopyTo(User[] array, int arrayIndex) {
                this._collection.CopyTo(array, arrayIndex);
            }

            public override IUserEnumerator GetEnumerator() {
                return this._collection.GetEnumerator();
            }

            public override int IndexOf(User value) {
                return this._collection.IndexOf(value);
            }

            public override void Insert(int index, User value) {
                CheckUnique(value);
                this._collection.Insert(index, value);
            }

            public override void Remove(User value) {
                this._collection.Remove(value);
            }

            public override void RemoveAt(int index) {
                this._collection.RemoveAt(index);
            }

            public override void RemoveRange(int index, int count) {
                this._collection.RemoveRange(index, count);
            }

            public override void Reverse() {
                this._collection.Reverse();
            }

            public override void Reverse(int index, int count) {
                this._collection.Reverse(index, count);
            }

            public override void Sort() {
                this._collection.Sort();
            }

            public override void Sort(IComparer comparer) {
                this._collection.Sort(comparer);
            }

            public override void Sort(int index, int count, IComparer comparer) {
                this._collection.Sort(index, count, comparer);
            }

            public override User[] ToArray() {
                return this._collection.ToArray();
            }

            public override void TrimToSize() {
                this._collection.TrimToSize();
            }

            #endregion
            #region Private Methods

            private void CheckUnique(User value) {
                if (IndexOf(value) >= 0)
                    throw new NotSupportedException(
                        "Unique collections cannot contain duplicate elements.");
            }

            private void CheckUnique(int index, User value) {
                int existing = IndexOf(value);
                if (existing >= 0 && existing != index)
                    throw new NotSupportedException(
                        "Unique collections cannot contain duplicate elements.");
            }

            #endregion
        }

        #endregion
    }

    #endregion
}
